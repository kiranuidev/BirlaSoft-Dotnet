using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MusicStore.Entities;
using MusicStore.Service;
using MusicStoreApp.Model;
using MusicStoreApp.Utils;

namespace MusicStoreApp.UI.Album
{
    public partial class AlbumList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = new List<MusicStoreApp.Model.Album>();
            //var evenRecords = data.Aggregate((a,b)=>a.Price+b.Price);
            int[] array = { 1, 2, 3, 4, 5 };
            var total = array.Max();
            string user = "Kiran PVS";
            var ouput = user.GetLastFour();
            if (Session["AlbumData"] != null)
            {
                data = (List<MusicStoreApp.Model.Album>)Session["AlbumData"];
            }
            else
            {
                data = GetAllAlbums();
                Session["AlbumData"] = data;
            }
           
            grdAlbums.DataSource = data;
            grdAlbums.DataBind();
        }

        private List<MusicStoreApp.Model.Album> GetAllAlbums()
        {
            //var service = new AlbumService();
            //var result = service.GetAll();
            var album = new EFAlbum();
            return album.GetAll();
        }
    }
}