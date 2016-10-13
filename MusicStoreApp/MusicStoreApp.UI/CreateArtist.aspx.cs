using MusicStore.Entities.Entities;
using MusicStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreApp.UI
{
    public partial class CreateArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create(object sender, EventArgs e)
        {
            IArtistService service = new ArtistService();
            Artist artist = new Artist();
             artist.Name = txtArtist.Text;
            service.CreateArtist(artist);
        }
    }
}