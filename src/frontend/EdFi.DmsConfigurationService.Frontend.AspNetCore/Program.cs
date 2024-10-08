// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseRouting();

app.MapGet("/", () => "DMS Configuration Service");
app.MapGet("/ping", () => Results.Text(DateTime.Now.ToString()));

app.Run();

public partial class Program
{
    // Compliant solution for Sonar lint S1118
    private Program() { }
}
