namespace VertoWebforms.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VertoWebforms.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VertoWebforms.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VertoWebforms.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Images.AddOrUpdate(c => c.imageId,
               //catagories
                new ImagesModel { imageId = 1, imageLocation = "~/Images/CatagoriesImages/VertoBinocularsImageOne.png", imageUploadDate = DateTime.Now },
                new ImagesModel { imageId = 2, imageLocation = "~/Images/CatagoriesImages/VertoBinocularsImageTwo.png", imageUploadDate = DateTime.Now },
                new ImagesModel { imageId = 3, imageLocation = "~/Images/CatagoriesImages/VertoBinocularsImageThree.png", imageUploadDate = DateTime.Now },
                new ImagesModel { imageId = 4, imageLocation = "~/Images/CatagoriesImages/VertoBinocularsImageFour.png", imageUploadDate = DateTime.Now },
                
                //special Offers
                new ImagesModel { imageId = 5, imageLocation = "~/Images/OfferImages/VertoMoneyImageOne.png", imageUploadDate = DateTime.Now },
               new ImagesModel { imageId = 6, imageLocation = "~/Images/OfferImages/VertoOlympusImageOne.png", imageUploadDate = DateTime.Now },
               new ImagesModel { imageId = 7, imageLocation = "~/Images/OfferImages/VertoTelecopeImageOne.png", imageUploadDate = DateTime.Now },
                
               //product 
               new ImagesModel { imageId = 8, imageLocation = "~/Images/ProductImages/VertoBirdImageOne.png", imageUploadDate = DateTime.Now },
               //news 
               new ImagesModel { imageId = 9, imageLocation = "~/Images/NewsImages/VertoLandscapeShotOne.png", imageUploadDate = DateTime.Now },
               //feild 
               new ImagesModel { imageId = 10, imageLocation = "~/Images/EventImages/VertoBirdWatchersOne.png", imageUploadDate = DateTime.Now },
               //gallery 
               new ImagesModel { imageId = 11, imageLocation = "~/Images/GalleryImages/VertoBirdImageTwo.png", imageUploadDate = DateTime.Now }
                
                );


            context.catagories.AddOrUpdate(c => c.Catagory,
            new catagoriesModel
            {
                CatagoryId = 1,
                Catagory = "Binoculars",
                imageModelId = 1
            },
             new catagoriesModel
            {
                CatagoryId = 2,
                Catagory = "Compact Binoculars",
                imageModelId = 2
            },
             new catagoriesModel
            {
                CatagoryId = 3,
                Catagory = "Ielescopes & eyepieces",
                imageModelId = 3
            },
             new catagoriesModel
            {
                CatagoryId = 4,
                Catagory = "Observation & Marine",
                imageModelId = 4
            }
                );

            context.offers.AddOrUpdate(c => c.offerTitle,
              new offersModel
              {
                  offerId = 1,
                  offerTitle = "Discovery WP PC",
                  Offer = "£20 Cashback",
                  offerDate = DateTime.Now,
                  imageModelId = 5
              },
              new offersModel
              {
                  offerId = 2,
                  offerTitle = "HR CD Fieldscopes",
                  Offer = "Free Digiscoping Kit",
                  offerDate = DateTime.Now,
                  imageModelId = 6
              },
               new offersModel
               {
                   offerId = 3,
                   offerTitle = "IS 60 WP Fieldscope Kits",
                   Offer = "Save 25%",
                   offerDate = DateTime.Now,
                   imageModelId = 7
               }
               );

            context.products.AddOrUpdate(c => c.Title,
                new ProductsModel
                {
                    Title = "A product 1",
                    catagoryModelId = 1,
                    description = "Visionary’s ED model in their new Fieldtracker range is a handsome-looking binocular, with an open-bridge design that makes it extremely comfortable in the hand. It feels good, too, with green rubber armour that’s reassuringly solid yet compact and lightweight, something that could be said about this model more generally.",
                    imageModelId = 8,
                    productCreationDate = DateTime.Now
                }

                );

            context.newsArticles.AddOrUpdate(c => c.Title,
                new NewsModel { Title = "news story 1", 
                    story = "Two White-tailed Eagle chicks symbolic of a new future for their forest home have been named Saorsa and Dochas after a public vote.The winning names beat contenders such as Haggis and Neeps, and Birdy and Beaky McBirdface.The pair hatched in the midst of a £4.5 million appeal to buy and restore Loch Arkaig Forest in the Scottish Highlands, which is being sold as part of the National Forest Land Scheme. The scheme allows community organisations to buy land where this will increase public value.", 
                    ArticleCreationDate = DateTime.Now, imageModelId = 9 }
                );

            context.feildEvents.AddOrUpdate(c => c.Title,
                new FieldEventsModel { Title = "Test field Event one",
                    description = "ey can be anything from the birds you see on your back garden feeders, to seabirds passing offshore as you relax on the beach. There are no restrictions on where you do your birdwatching, and you won’t have to wait for your ticks to be approved by a committee – it’s all about enjoying new birds, and learning more about the wildlife all around us.",
                                       imageModelId = 10,
                                       EventCreationDate = DateTime.Now
                }
                );

            context.Gallery.AddOrUpdate(c => c.title,
                new GalleryModel { title = "Gallery One", 
                    description = "Birds (Aves), (sometimes termed avian dinosaurs) are a group of endothermic vertebrates, characterised by feathers, toothless beaked jaws, the laying of hard-shelled eggs, a high metabolic rate, a four-chambered heart, and a lightweight but strong skeleton.",
                    imageModelId = 11, galleryDate=DateTime.Now }
                );

           

        }
    }
}
