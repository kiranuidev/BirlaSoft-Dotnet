using MusicStore.Entities;
using MusicStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreApp.UI.Album
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropdownData();
            
        }
        protected void CreateAlbum(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var service = new MusicStoreApp.Model.EFAlbum();
                var album = new MusicStoreApp.Model.Album();
                album.ArtistId = Convert.ToInt32(ddlArtist.SelectedValue);
                album.GenreId = Convert.ToInt32(ddlGenre.SelectedValue);
                album.AlbumArtUrl = AlbumArtUrl.Text;
                album.Price = Convert.ToInt32(txtPrice.Text);
                album.Title = txtName.Text;
                service.CreateAlbum(album);
                Response.Redirect("~/Album/AlbumList.aspx");
            }

        }

        private void BindDropdownData()
        {
            ddlGenre.DataSource = GetGenreList();
            ddlGenre.DataTextField = "Name";
            ddlGenre.DataValueField = "GenreId";
            ddlGenre.DataBind();

            ddlArtist.DataSource = GetArtistList();
            ddlArtist.DataTextField = "Name";
            ddlArtist.DataValueField = "ArtistId";
            ddlArtist.DataBind();

        }


        private List<MusicStoreApp.Model.Genre> GetGenreList()
        {
            var service = new MusicStoreApp.Model.EFAlbum();
            return service.GetGenre();
            // var service = new GenreService();
            //return service.GetAllGenre();

        }
        private List<MusicStoreApp.Model.Artist> GetArtistList ()
        {
            var service = new MusicStoreApp.Model.EFAlbum();
            return service.GetArtists();
            //var service = new ArtistService();
            //return service.GetArtists();
        }


    }
}