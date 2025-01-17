﻿using UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DL.Entities;
using BL;
using DL;
using System.IO;

var configuration = new ConfigurationBuilder() //this adds the required information to build the db to the right places
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration.GetConnectionString("RearlesDB"); //this sets the connection string

DbContextOptions<RearlesDBContext> options = new DbContextOptionsBuilder<RearlesDBContext>() //this calls the dbcontext to set up the connection for the db
    .UseSqlServer(connectionString)
    .Options;

var context = new RearlesDBContext(options); //sets up to use the connection

IMenu menu = new MainMenu(new ReviewBL(new ReviewRepo(context))); //sets up menu in UI to call DL inside of BL

menu.Start(); //this starts the program and at this point we are connected to my db