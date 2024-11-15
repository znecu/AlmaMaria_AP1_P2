﻿using AlmaMaria_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmaMaria_AP1_P2.DAL;

public class Contexto :DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Registro> Registro { get; set; }   
}
