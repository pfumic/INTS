using INTS_MLNET_PROJEKT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTS_MLNET_PROJEKT.Services
{
    class ReviewService
    {
        public ReviewService() {

        }

        public List<Review> GetAllReviews() {
            bool headers = true;
            List<Review> allReviews = new List<Review>();
            using (var reader = new StreamReader(@"C:\Users\Patrik Fumic\source\repos\INTS_MLNET_PROJEKT\INTS_MLNET_PROJEKT\Data\hotel_ratings_final.csv")) {

                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (headers) {
                        headers = false;
                        continue;
                    }

                    Review tempSet = new Review {
                        HotelId = float.Parse(values[0]),
                        Rating = float.Parse(values[1]),
                        UserId = float.Parse(values[2])
                    };

                    allReviews.Add(tempSet);
                }

                //foreach (var item in MLsets) {
                //    Console.WriteLine(item.hotelId + " " + item.rating + " " + item.username);
                //}
            }

            return allReviews;
        }
    }
}
