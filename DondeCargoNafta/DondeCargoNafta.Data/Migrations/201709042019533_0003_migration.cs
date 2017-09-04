namespace DondeCargoNafta.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0003_migration : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO Stations (StationName, IsGNC, Address_AddressID, Brand_BrandID, Coordinates_LocationID) VALUES ('El Surtidor', 1, 1, 6, 1);

                INSERT INTO Stations (StationName, IsGNC, Address_AddressID, Brand_BrandID, Coordinates_LocationID) VALUES ('A.C.A. Oroño', 1, 2, 6, 2);

                INSERT INTO Stations (StationName, IsGNC, Address_AddressID, Brand_BrandID, Coordinates_LocationID) VALUES ('Shell Oroño', 0, 3, 5, 3);

                INSERT INTO Stations (StationName, IsGNC, Address_AddressID, Brand_BrandID, Coordinates_LocationID) VALUES ('ESSO Oroño', 0, 4, 2, 4);

                INSERT INTO Stations (StationName, IsGNC, Address_AddressID, Brand_BrandID, Coordinates_LocationID) VALUES ('GNC Mitre y Zeballos', 1, 5, 7, 5);

                INSERT INTO Stations (StationName, IsGNC, Address_AddressID, Brand_BrandID, Coordinates_LocationID) VALUES ('OIL Diagonal Maipu', 0, 6, 3, 6);
                "
            );
        }

        public override void Down()
        {
        }
    }
}
