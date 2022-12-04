namespace ShevkunenkoSite.Services;

//If you need to reset the database, then run this command in the ShevkunenkoSite.Services folder:
//dotnet ef database --startup-project ..\ShevkunenkoSite  drop --force --context SiteDbContext

public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        SiteDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<SiteDbContext>();

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }

        if (!context.PageInfo.Any())
        {
            context.PageInfo.AddRange(
            new PageInfoModel
            {
                PageTitle = "Сайт памяти Сергея Шевкуненко",
                PageDescription = "Эта история по-своему уникальна и практически не имеет " +
                    "аналогов в истории российского кинематографа. Подававший большие надежды " +
                    "актер волею судьбы угодил в тюрьму и довольно быстро добился славы и " +
                    "признания совсем в другой среде - уголовной. Последней ступенькой, " +
                    "на которую сумел забраться в преступной иерархии этот бывший актер, " +
                    "была должность «положенца», которая предшествует самому высокому " +
                    "титулу в уголовной среде - вора в законе. Имя этого человека - " +
                    "Сергей Шевкуненко.",
            }
            );

            context.SaveChanges();
        }
    }
}
