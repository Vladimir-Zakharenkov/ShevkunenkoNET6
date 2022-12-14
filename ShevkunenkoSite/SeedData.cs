﻿//If you need to reset the database, then run this command in the ShevkunenkoSite.Services folder:
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

        if (!context.BackgroundFile.Any())
        {
            context.BackgroundFile.AddRange(
                new BackgroundFileModel
                {
                    LeftBackground = "FotoPlenka.png",

                    RightBackground = "FotoPlenka.png"
                },
                new BackgroundFileModel
                {
                    LeftBackground = "biografy-left.png",

                    RightBackground = "biografy-right.png"
                });

            context.SaveChanges();
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

                PageKeyWords = "сергей шевкуненко,сергей шевкуненко фото,сергей " +
                    "шевкуненко криминальная,шевкуненко сергей юрьевич,сергей шевкуненко биография," +
                    "сергей шевкуненко криминальная биография,сергей шевкуненко убийство," +
                    "сергей шевкуненко фото убийство,сергей шевкуненко жена,сергей шевкуненко википедия," +
                    "фильм криминальная звезда сергей шевкуненко,сергей шевкуненко похороны," +
                    "актер сергей шевкуненко,памяти сергей шевкуненко,сергей шевкуненко документальный фильм," +
                    "сергей шевкуненко документальный фильм криминальная звезда,криминальная звезда " +
                    "документальный фильм памяти сергея шевкуненко,сергей шевкуненко видео," +
                    "сестра сергея шевкуненко,шевкуненко сергей юрьевич похороны,сергей шевкуненко кортик," +
                    "елена шевкуненко жена сергея шевкуненко,сергей шевкуненко могила," +
                    "сергей шевкуненко смерть,сергей шевкуненко похороны видео,сергей шевкуненко личная жизнь," +
                    "сергей шевкуненко фото смерть,шевкуненко сергей юрьевич вспоминают друзья," +
                    "актер сергей шевкуненко биография,судьба сергея шевкуненко," +
                    "сергей шевкуненко фото перед смертью,сергей шевкуненко криминал," +
                    "шевкуненко сергей юрьевич криминал",

                PageLastmod = DateTime.Today,

                PageLoc = "Index",

                BackgroundFileModelId = new("E073BDDD694F4818A0C308DADB48DCD9")
            }
            );

            context.SaveChanges();
        }
    }
}
