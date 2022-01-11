using AgenziaGite;

using (var ctx = new AgenziaGiteContext())
{
    ctx.Database.EnsureCreated();
}