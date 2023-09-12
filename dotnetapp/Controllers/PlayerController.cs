using Microsoft.AspNetCore.Mvc;
using dotnetapp.Service;
using dotnetapp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace dotnetapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly IPlayersService _playerService;

    public PlayersController(IPlayersService playerService)
    {
        _playerService = playerService;
    }

    //Imclude the code here
}