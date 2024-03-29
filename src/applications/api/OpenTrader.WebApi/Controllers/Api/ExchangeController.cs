﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OpenTrader.Constants.General;
using Microsoft.AspNetCore.Authorization;
using OpenTrader.Exchange.Service.Interfaces;

namespace OpenTrader.WebApi.Controllers.Api;

/// <summary> Controller work with exchanges </summary>
/// <param name="logger"></param>
/// <param name="imageService"></param>
/// <param name="exchangeService"></param>
[Authorize]
[ApiController]
[Route("~/api/v1/[controller]/")]
[EnableCors(CorsPolicies.AllowAll)]
public class ExchangeController(ILogger<ExchangeController> logger, IExchangeService exchangeService, IExchangeImageService imageService) : Controller
{
    /// <summary> </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    [Authorize, HttpGet]
    [ResponseCache(Duration = 1200, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> ListAsync(CancellationToken token)
    {
        return Ok((await exchangeService.CollectionAsync(token)).ToArray());
    }
    
    /// <summary> Return svg image from s3 </summary>
    /// <param name="name"></param>
    /// <param name="token"></param>
    /// <response code="200">Return <c>ClaimIdentity</c> from <c>HttpContext</c>></response>
    /// <response code="500">Unhandled exception</response>
    [Authorize, HttpGet("{name}/image")]
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> ImageAsync(string name, CancellationToken token)
    {
        try
        {
            var imageResult = await imageService.DownloadImageByName(name, token);
            return File(imageResult.FileStream, imageResult.ContentType);
        }
        catch (Exception exception)
        {
            logger.Log(LogLevel.Error, "{Exception}", exception.Message);
            return Problem(exception.Message);
        }
    }
}