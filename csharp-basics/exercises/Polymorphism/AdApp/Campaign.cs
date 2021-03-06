using System.Collections.Generic;
using System.Linq;
using System;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> campaign;

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            foreach (Advert type in campaign)
            {
                Console.WriteLine("Advert Campaign " + type.Cost());
            }
            return "\nTotal Cost = "+ GetCost();
        }
    }
}