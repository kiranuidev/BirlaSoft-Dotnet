using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MusicStore.Entities;
using MusicStore.Service;

namespace MusicStoreApp.UI.Album
{
    public partial class AlbumList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grdAlbums.DataSource= GetAllAlbums();
            grdAlbums.DataBind();
        }

        private List<MusicStore.Entities.Entities.Album> GetAllAlbums()
        {
            var service = new AlbumService();
            var result = service.GetAll();
            return result;
        }
    }
}