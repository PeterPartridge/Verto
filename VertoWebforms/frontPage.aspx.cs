using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VertoWebforms.Models;

namespace VertoWebforms
{

    public partial class _frontPage : Page
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            var productQuery = (from c in _db.Images
                                  join d in _db.products on c.imageId equals d.imageModelId
                                  select new
                                  {
                                      Image = c.imageLocation,
                                     d.Title,
                                     d.description,
                                     d.productCreationDate
                                  }).ToList().OrderByDescending(c=>c.productCreationDate).FirstOrDefault();

            var newsQuery = (from c in _db.Images
                             join d in _db.newsArticles on c.imageId equals d.imageModelId
                             select new
                             {
                                 Image = c.imageLocation,
                                 d.Title,
                                 d.story,
                                 d.ArticleCreationDate
                             }).ToList().OrderByDescending(c => c.ArticleCreationDate).FirstOrDefault();

            var fieldEvents = (from c in _db.Images
                               join d in _db.feildEvents on c.imageId equals d.imageModelId
                               select new
                               {
                                   Image = c.imageLocation,
                                   d.Title,
                                   d.description,
                                   d.EventCreationDate
                               }).ToList().OrderByDescending(c => c.EventCreationDate).FirstOrDefault();


            var galleryQuery = (from c in _db.Images
                                join d in _db.Gallery on c.imageId equals d.imageModelId
                                select new
                                {
                                    Image = c.imageLocation,
                                    d.title,
                                    d.description,
                                    d.galleryDate
                                }).ToList().OrderByDescending(c => c.galleryDate).FirstOrDefault();

            var catagoryList = (from c in _db.Images
                                  join d in _db.catagories on c.imageId equals d.imageModelId
                                  select new
                                  {
                                      image = c.imageLocation,
                                     catagory = d.Catagory
                                  }).ToList().OrderBy(c=>c.catagory);


                //products boxes population
                productImage.ImageUrl = productQuery.Image;
                productImage.AlternateText = productQuery.Title;
                newProductTextBox.Text = productQuery.description;

                //news boxes population
                latestNewsTextBox.Text = newsQuery.story;
                newsImage.ImageUrl = newsQuery.Image;
                newsImage.AlternateText = newsQuery.Title;
                //events box population
                feildEventTextBox.Text = fieldEvents.description;
                eventImage.ImageUrl = fieldEvents.Image;
                eventImage.AlternateText = fieldEvents.Title;
                //bird ox populaiton
                birdImagesTextBox.Text = galleryQuery.description;
                galleryImage.ImageUrl = galleryQuery.Image;
                galleryImage.AlternateText = galleryQuery.title;

                Repeater1.DataSource = catagoryList;
                Repeater1.DataBind();
            
                
                        

                
            }

            catch
            {
               
            }
            
        }

       
    }
}