namespace RentMyWrox
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RentMyWroxContext : DbContext
    {
        // Your context has been configured to use a 'RentMyWroxContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RentMyWrox.RentMyWroxContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RentMyWroxContext' 
        // connection string in the application configuration file.
        public RentMyWroxContext()
            : base("name=RentMyWroxContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Models.UserDemographics> UserDemographics { get; set; }
        public virtual DbSet<Models.Hobby> Hobbies { get; set; }
    }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}