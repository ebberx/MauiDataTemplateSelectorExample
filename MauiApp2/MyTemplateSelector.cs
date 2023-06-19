using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{
    public class MyTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FruitTemplate { get; set; }
        public DataTemplate AnimalTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) {
            return item is Fruit ? FruitTemplate : AnimalTemplate;
        }
    }
}
