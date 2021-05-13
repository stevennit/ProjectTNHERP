using elFinder.NetCore;
using elFinder.NetCore.Drivers.FileSystem;
using Hiver.BackendApi.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class FileSystemController : ControllerBase
    {
        [HttpPost("connector")]
        //[EnableCors("AnotherPolicy")]
        public async Task<IActionResult> Connector()
        {
            var connector = GetConnector();
            return await connector.ProcessAsync(Request);
        }

        [HttpGet("thumb/{hash}")]
        //[EnableCors("AnotherPolicy")]
        public async Task<IActionResult> Thumbs(string hash)
        {
            var connector = GetConnector();
            return await connector.GetThumbnailAsync(HttpContext.Request, HttpContext.Response, hash);
        }

        private Connector GetConnector()
        {
            var driver = new FileSystemDriver();

            string absoluteUrl = UriHelper.BuildAbsolute(Request.Scheme, Request.Host);
            var uri = new Uri(absoluteUrl);

            var root = new RootVolume(
                PathHelper.MapPath("~/Files"),
                $"{uri.Scheme}://{uri.Authority}/Files/",
                $"{uri.Scheme}://{uri.Authority}/api/FileSystem/thumb/")
            {
                //IsReadOnly = !User.IsInRole("Administrators")
                IsReadOnly = false, // Can be readonly according to user's membership permission
                IsLocked = false, // If locked, files and directories cannot be deleted, renamed or moved
                Alias = "Files", // Beautiful name given to the root/home folder
                //MaxUploadSizeInKb = 2048, // Limit imposed to user uploaded file <= 2048 KB
                AccessControlAttributes = new HashSet<NamedAccessControlAttributeSet>()
                {
                    new NamedAccessControlAttributeSet(PathHelper.MapPath("~/Files/readonly.txt"))
                    {
                        Write = false,
                        Locked = true
                    },
                    new NamedAccessControlAttributeSet(PathHelper.MapPath("~/Files/Prohibited"))
                    {
                        Read = false,
                        Write = false,
                        Locked = true
                    },
                    new NamedAccessControlAttributeSet(PathHelper.MapPath("~/Files/Parent/Children"))
                    {
                        Read = true,
                        Write = false,
                        Locked = true
                    }
                }
            };

            driver.AddRoot(root);

            return new Connector(driver)
            {
                // This allows support for the "onlyMimes" option on the client.
                MimeDetect = MimeDetectOption.Internal
            };
        }
    }
}
