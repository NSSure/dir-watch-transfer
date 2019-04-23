using dir_watch_transfer_ui.Model;
using System.Collections.Generic;

namespace dir_watch_transfer_ui
{
    public class DirWatchTransferApp
    {
        public static List<SymbolicLink> SymbolicLinks { get; set; } = new List<SymbolicLink>();

        public static List<ImageConfig> ListViewImageList
        {
            get
            {
                return new List<ImageConfig>()
                {
                    LinkedFolderImageConfig, StatusInformationImageConfig, TimeImageConfig, LinkImageConfig
                };
            }
        }

        public static ImageConfig LinkedFolderImageConfig = new ImageConfig()
        {
            ImageIndex = 0,
            Path = "Images/LinkedFolder.png"
        };

        public static ImageConfig StatusInformationImageConfig = new ImageConfig()
        {
            ImageIndex = 1,
            Path = "Images/StatusInformation.png"
        };

        public static ImageConfig TimeImageConfig = new ImageConfig()
        {
            ImageIndex = 2,
            Path = "Images/Time.png"
        };

        public static ImageConfig LinkImageConfig = new ImageConfig()
        {
            ImageIndex = 3,
            Path = "Images/Link.png"
        };
    }
}
