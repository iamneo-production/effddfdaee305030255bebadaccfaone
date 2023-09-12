using System;
using System.Collections;
using System.Collections.Generic;
using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Service;
public class PlayersService : IPlayersService
{
    private readonly FootballdbContext _context;

    public PlayersService(FootballdbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Player>> GetPlayersList()
    {
        return await _context.Players
            .Include(x => x.Position)
            .ToListAsync();
    }

    public async Task<Player> GetPlayerById(int id)
    {
        return await _context.Players
            .Include(x => x.Position)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Player> CreatePlayer(Player player)
{
        //_context.Players.Add(player);
        //await _context.SaveChangesAsync();
        return player;
    
}
    
}