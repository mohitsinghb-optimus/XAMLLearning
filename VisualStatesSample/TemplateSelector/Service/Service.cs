using System.Collections.ObjectModel;
using TemplateSelector.Model;

namespace TemplateSelector.Service
{
    public static class Service
    {
        public static ObservableCollection<Entity> GetAllEntities()
        {
            var entityListModel = new ObservableCollection<Entity>()
            {
               new Entity
                 {
                    Description = "This is First Product",
                    ID = 1,
                    Image = "/Assets/3734.jpg"
                 },
              new Entity
                 {
                   Description = "This is Second Product",
                   ID = 2,
                   Image = "/Assets/3502.jpg"
                 },
              new Entity
                {
                  Description = "This is Third Product",
                  ID = 3,
                  Image = "/Assets/3736.jpg"
                },
              new Entity
                {
                  Description = "This is Fourth Product",
                  ID = 4,
                  Image = "/Assets/3738.jpg"
                },
              new Entity
               {
                Description = "This is Fifth Product",
                ID = 5,
                Image = "/Assets/3932.jpg"
               }
            };

            return entityListModel;
        }
    }
}
