using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Primitives;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using SAOCPSEDB.ClaimForm.Forms;
using SAOCPSEDB.ClaimForm.Forms.Claim;
using SAOCPSEDB.ClaimForm.Logic;
using SAOCPSEDB.Models;
using MediatR;
using ClaimFormBusiness.Requests;
using ClaimFormBusiness.Dtos;

namespace ClaimFormApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimFormController : ControllerBase
    {
        private readonly IMediator Mediator;
        // TEMP FOR TESTING. THIS MEANS ONLY ONE USER CAN CREATE FORM AT A TIME
        public static ClaimDetailsForm ClaimDetailsForm { get; set; }


        private readonly SbcDbContext _context;

        public ClaimFormController(SbcDbContext context, IMediator mediator)
        {
            _context = context;
            if(ClaimDetailsForm == null)
                ClaimDetailsForm = new ClaimDetailsForm(_context);
            Mediator = mediator;
        }

        [HttpGet]
        public IEnumerable GetInit()
        {
            ClaimDetailsForm = new ClaimDetailsForm(_context);
            return ClaimDetailsForm.ToJson();
        }

        [HttpPost("Callback")]
        public IEnumerable PostCallback(CallbackDto callback)
        {
            ClaimDetailsForm.Update(callback);
            return ClaimDetailsForm.GetJsonDelta();
        }

        [HttpPost]
        public async Task<ActionResult> Submit([FromBody] ClmfrmClaimXDto clmfrmClaimXDto)
        {
            return Ok(await Mediator.Send(new ClaimFormSubmitRequest(clmfrmClaimXDto)));   
            //if (formData.Keys.Count == 0)
            //    return BadRequest("No Data");

            //ClaimDetailsForm.Update(formData);

            //var errors = ClaimDetailsForm.Validate();
            //if (errors.Any())
            //    return BadRequest(errors);

            //if (!formData.TryGetValue("html", out StringValues html) || string.IsNullOrEmpty(html))
            //    return BadRequest("Could not generate PDF."); // Probably shouldn't be error

            //using (Doc theDoc = new Doc())
            //{
            //    // string baseUrl = "C:\\src\\SAOCPSE\\ClaimForm\\";
            //    theDoc.HtmlOptions.BaseURI = "http://localhost:5062/";
            //    string htmlWithAbsolutePaths = ReplaceRelativePaths(html.ToString(), theDoc.HtmlOptions.BaseURI);

            //    // Replace relative paths with absolute paths
            //    /*string htmlWithAbsolutePaths = html.ToString().Replace("href=\"./", $"href=\"{baseUrl}")
            //        .Replace("src=\"./", $"src=\"{baseUrl}/")
            //        .Replace("url(\"./", $"url(\"{baseUrl}/")
            //        .Replace("href=\"/", $"href=\"{baseUrl}/")
            //        .Replace("src=\"/", $"src=\"{baseUrl}/")
            //        .Replace("url(\"/", $"url(\"{baseUrl}/");

            //    htmlWithAbsolutePaths = htmlWithAbsolutePaths.Replace("src/assets/AppThemes", "App_Themes");
            //    htmlWithAbsolutePaths = htmlWithAbsolutePaths.Replace("App_Themes/font-awesome-4.7.0", "Content\\font-awesome-4.7.0");
            //    htmlWithAbsolutePaths = htmlWithAbsolutePaths.Replace("/src/assets/Images", "Images");*/

            //    // var AbsoluteUrl = "http://localhost:5173/";
            //    // var htmlWithAbsolutePaths = html.ToString().Replace("href=\"", "href=\"" + "file://" + AbsoluteUrl + "/");
            //    // htmlWithAbsolutePaths = htmlWithAbsolutePaths.Replace("src=\"../", "src=\"" + "file://" + AbsoluteUrl + "/../");
            //    // htmlWithAbsolutePaths = htmlWithAbsolutePaths.Replace("src=\"" + "file://" + AbsoluteUrl + "/data:image", "src=\"data:image"); // remove absolute path substitution if it's image data src.

            //    // Set the page dimensions (optional)
            //    theDoc.MediaBox.String = "A4";
            //    theDoc.Rect.String = theDoc.MediaBox.String;
            //    theDoc.Rect.Pin = XRect.Corner.TopLeft;
            //    // Add the HTML content to the PDF
            //    theDoc.HtmlOptions.Engine = EngineType.Chrome86; // Better rendering for complex pages
            //    // theDoc.AddImageHtml(htmlWithAbsolutePaths);
            //    theDoc.AddImageHtml(htmlWithAbsolutePaths, true, 1200, true);

            //    // Convert to byte array for response
            //    byte[] pdfBytes = theDoc.GetData();

            //    System.IO.File.Delete("C:\\Users\\Joshua Carse\\Desktop\\temp\\Documents\\Temp.html");
            //    System.IO.File.Delete("C:\\Users\\Joshua Carse\\Desktop\\temp\\Documents\\Temp.pdf");
            //    await System.IO.File.WriteAllBytesAsync(@"C:\Users\Joshua Carse\Desktop\temp\Documents\Temp.pdf", pdfBytes);
            //    await System.IO.File.WriteAllTextAsync(@"C:\Users\Joshua Carse\Desktop\temp\Documents\Temp.html", htmlWithAbsolutePaths);

            //    return BadRequest("test");
            //    var newDoc = new ClmfrmClaimdocumentX { Isclaimform = 1 };
            //    newDoc.Document = new DmsDocument();
            //    newDoc.Document.Filename = $"{ClaimDetailsForm.Claim.Claimformnumber}.pdf";
            //    var revision = new DmsRevision();
            //    var revisionFile = new DmsRevisionfile
            //    {
            //        Document = pdfBytes
            //    };
            //    revision.DmsRevisionfile = revisionFile;
            //    newDoc.Document.DmsRevisions.Add(revision);
            //    ClaimDetailsForm.Claim.ClmfrmClaimdocumentXes.Add(newDoc);

            //    // return File(pdfBytes, "application/pdf", $"{ClaimDetailsForm.Claim.Claimformnumber}.pdf");
            //}

            //await ClaimDetailsForm.SaveAsync();

            //return Created("Submit", new { ClaimId = ClaimDetailsForm.Claim.Claimformid, ClaimDetailsForm.Claim.Claimformnumber });
        }

        //private string ReplaceRelativePaths(string html, string baseUrl)
        //{
        //    return html.Replace("href=\"./", $"href=\"{baseUrl}/")
        //        .Replace("src=\"./", $"src=\"{baseUrl}/")
        //        .Replace("url(\"./", $"url(\"{baseUrl}/")
        //        .Replace("href=\"/", $"href=\"{baseUrl}/")
        //        .Replace("src=\"/", $"src=\"{baseUrl}/")
        //        .Replace("url(\"/", $"url(\"{baseUrl}/")
        //        .Replace("class=\"container\"", "");
        //}

        //[HttpPost("Submit_Bak")]
        //public async Task<ActionResult> Submit_Bak([FromForm] IFormCollection formData)
        //{
        //    var form = Request.Form;
        //    // var test = JsonConvert.DeserializeObject<CallbackDto[]>(form["formFields"]);

        //    if (formData.Keys.Count == 0)
        //        return BadRequest("No Data");

        //    var callBackDtos = new List<CallbackDto>();

        //    foreach (var key in formData.Keys)
        //    {
        //        callBackDtos.Add(new CallbackDto(key, formData[key]));
        //    }

        //    foreach (var callbackDto in callBackDtos)
        //        ClaimDetailsForm.Update(callbackDto);

        //    var errors = ClaimDetailsForm.Validate();
        //    if (errors.Any())
        //        return BadRequest(errors);

        //    await ClaimDetailsForm.SaveAsync();

        //    return Created("Submit", new { ClaimId = ClaimDetailsForm.Claim.Claimformid, ClaimDetailsForm.Claim.Claimformnumber });
        //}

        //[HttpPost("SelectBsbOperation")]
        //public async Task<IEnumerable> PostSelectBsbOperation([FromBody] int bsbId)
        //{
        //    await PopulateBankDetails(bsbId);
        //    return ClaimDetailsForm.GetJsonDelta(true);
        //}

        //public async Task PopulateBankDetails(int bsbId)
        //{
        //    if (bsbId > 0)
        //    {
        //        var bsbBranch = await _context.BsbBranches.FirstOrDefaultAsync(x => x.Bsbid == bsbId);
        //        if (bsbBranch == null)
        //            return;

        //        // ClaimDetailsForm.Update(new CallbackDto {FieldName = "Workerbsb1", Value = bsbBranch.Bsb1});
        //        ClaimDetailsForm.Claim.Workerbsb1 = bsbBranch.Bsb1;
        //        ClaimDetailsForm.Claim.Workerbsb2 = bsbBranch.Bsb2;
        //        ClaimDetailsForm.Claim.Workerbankname = _context.Zprimarycodes.FirstOrDefault(c => c.Zone == 0 && c.CodeType == "BANK" && c.CodeValue == bsbBranch.Bank)?.DisplayValue;
        //        ClaimDetailsForm.Claim.Workerbranchname = bsbBranch.Branch;
        //    }
        //}
    }
}
