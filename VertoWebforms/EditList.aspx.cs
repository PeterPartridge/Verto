using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VertoWebforms.Models;

namespace VertoWebforms
{
    public partial class EditList : System.Web.UI.Page
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }
      
        // Edit the Gridview's row
        protected void editGriedView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            editGriedView.EditIndex = e.NewEditIndex;
            BindGridView();
        }

      
        protected void BindGridView()
        {
            string queryStringID = Request.QueryString["id"];
            
            if (queryStringID == "products")
            {
                var productQuery = (from c in _db.products
                                    orderby c.productCreationDate
                                    select new
                                    {

                                        id = c.productId,
                                        title = c.Title,
                                        bodyContent = c.description,
                                        c.productCreationDate
                                    }).ToList().OrderByDescending(c => c.productCreationDate);

                editGriedView.DataSource = productQuery;
                editGriedView.DataBind();
            }
            else if (queryStringID == "catagories")
            {
                var catagoryQuery = (from c in _db.catagories
                                     orderby c.Catagory
                                     select new
                                     {
                                         id = c.CatagoryId,
                                         title = c.Catagory,
                                         bodyContent = c.Catagory
                                     }).ToList().OrderByDescending(c => c.title);
                editGriedView.DataSource = catagoryQuery;
                editGriedView.DataBind();
            }
            else if (queryStringID == "offers")
            {
                var offerQuery = (from c in _db.offers
                                  orderby c.offerDate
                                  select new
                                  {
                                      id = c.offerId,
                                      title = c.offerTitle,
                                      bodyContent = c.Offer,
                                      c.offerDate
                                  }).ToList().OrderByDescending(c => c.offerDate);
                editGriedView.DataSource = offerQuery;
                editGriedView.DataBind();
            }
            else if (queryStringID == "field")
            {
                var feildQuery = (from c in _db.feildEvents
                                  orderby c.EventCreationDate
                                  select new
                                  {
                                      id = c.FeildeventId,
                                      title = c.Title,
                                      bodyContent = c.description,
                                      c.EventCreationDate
                                  }).ToList().OrderByDescending(c => c.EventCreationDate);
                editGriedView.DataSource = feildQuery;
                editGriedView.DataBind();

            }
            else if (queryStringID == "news")
            {
                var newsQuery = (from c in _db.newsArticles
                                 orderby c.ArticleCreationDate
                                 select new
                                 {
                                     id = c.storyId,
                                     title = c.Title,
                                     bodyContent = c.story,
                                     c.ArticleCreationDate
                                 }).ToList().OrderByDescending(c => c.ArticleCreationDate);
                editGriedView.DataSource = newsQuery;
                editGriedView.DataBind();
            }
            else if (queryStringID == "gallery")
            {
                var galleryQuery = (from c in _db.Gallery
                                    orderby c.galleryDate
                                    select new
                                    {
                                        title = c.title,
                                        id = c.galleryId,
                                        bodyContent = c.description,
                                        c.galleryDate
                                    }).ToList().OrderByDescending(c => c.galleryDate);
                editGriedView.DataSource = galleryQuery;
                editGriedView.DataBind();
            }
        }

        // Update the Gridview's row
        protected void editGriedView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Find the id for update the row
            Label id = (Label)editGriedView.Rows[e.RowIndex].FindControl("Edit_ID");
            int editId = Int32.Parse(id.Text);
            // Find new updated values for TexBox
            TextBox title = (TextBox)editGriedView.Rows[e.RowIndex].FindControl("ListTitleEdit");
            TextBox content = (TextBox)editGriedView.Rows[e.RowIndex].FindControl("bodyContentEdit");
            string queryStringID = Request.QueryString["id"];

            if (queryStringID == "products") { 
            // Select specific row from products database
            ProductsModel product = (from i in _db.products
                                   where i.productId == editId
                                   select i).First();
            product.Title = title.Text;
            product.description = content.Text;
            }
            else if (queryStringID == "news")
            {
                // Select specific row from products database
                NewsModel item = (from i in _db.newsArticles
                                         where i.storyId == editId
                                         select i).First();
                item.Title = title.Text;
                item.story = content.Text;
            }
            else if (queryStringID == "gallery")
            {
                // Select specific row from products database
                GalleryModel item = (from i in _db.Gallery
                                         where i.galleryId == editId
                                         select i).First();
                item.title = title.Text;
                item.description = content.Text;
            }
            else if (queryStringID == "field")
                {
                    // Select specific row from products database
                    FieldEventsModel item = (from i in _db.feildEvents
                                             where i.FeildeventId == editId
                                             select i).First();
                    item.Title = title.Text;
                }
            else if (queryStringID == "offers")
            {
                // Select specific row from offers database
               offersModel item = (from i in _db.offers
                                         where i.offerId == editId
                                         select i).First();
                item.offerTitle = title.Text;
                item.Offer = content.Text;
            }
            else if (queryStringID == "catagories")
            {
                // Select specific row from catagories database
                catagoriesModel item = (from i in _db.catagories
                                         where i.CatagoryId == editId
                                         select i).First();
                item.Catagory = title.Text;
            }
            
            // Update changes in database table
            _db.SaveChanges();

            editGriedView.EditIndex = -1;
            BindGridView();
        }

        // Cancel row edit operation
        protected void editGriedView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            editGriedView.EditIndex = -1;
            BindGridView();
        }
    
    }
}