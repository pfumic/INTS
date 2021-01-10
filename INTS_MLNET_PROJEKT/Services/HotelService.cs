using INTS_MLNET_PROJEKT.Models;
using INTS_MLNET_PROJEKTML.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTS_MLNET_PROJEKT.Services
{
    class HotelService
    {
        public List<Hotel> AllHotels { get; set; }
        private Dictionary<string, string> HotelIdsIntString = new Dictionary<string, string>();
        private Dictionary<string, string> HotelIdsStringInt = new Dictionary<string, string>();

        public HotelService() {
            AllHotels = GetAllHotels();
            HotelIdsIntString = GetHotelIdKeyValuePairsIntString();
            HotelIdsStringInt = GetHotelIdKeyValuePairsStringInt();
        }

        private List<Hotel> GetAllHotels() {
            bool headers = true;
            List<Hotel> allHotels = new List<Hotel>();
            using (var reader = new StreamReader(@"C:\Users\Patrik Fumic\source\repos\INTS_MLNET_PROJEKT\INTS_MLNET_PROJEKT\Data\hotel_ratings_final.csv")) {

                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (headers) {
                        headers = false;
                        continue;
                    }

                    Hotel tempSet = new Hotel {
                        Id = values[0],
                        Address = values[3],
                        Categories = values[4],
                        PrimaryCategories = values[5],
                        City = values[6],
                        Country = values[7],
                        Keys = values[8],
                        Name = values[11],
                        PostalCode = values[12],
                        Province = values[13],
                        Website = values[25]
                    };

                    allHotels.Add(tempSet);
                }

                //foreach (var item in MLsets) {
                //    Console.WriteLine(item.hotelId + " " + item.rating + " " + item.username);
                //}
            }

            return allHotels;
        }

        private Dictionary<string, string> GetHotelIdKeyValuePairsIntString() {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            using (var reader = new StreamReader(@"C:\Users\Patrik Fumic\source\repos\INTS\INTS_MLNET_PROJEKT\Data\hotel_id_key_value.csv")) {

                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    keyValuePairs.Add(values[1], values[0]);
                }
            }

            return keyValuePairs;
        }

        private Dictionary<string, string> GetHotelIdKeyValuePairsStringInt() {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            using (var reader = new StreamReader(@"C:\Users\Patrik Fumic\source\repos\INTS\INTS_MLNET_PROJEKT\Data\hotel_id_key_value.csv")) {

                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    keyValuePairs.Add(values[0], values[1]);
                }
            }

            return keyValuePairs;
        }

        public Hotel GetHotelByStringId(string Id) {
            Hotel result = new Hotel();

            foreach (var item in AllHotels) {
                if (item.Id.Equals(Id)) {
                    result = item;
                    break;
                }
            }

            return result;
        }
        

        public Hotel GetHotelByIntId(string Id) {
            HotelIdsIntString.TryGetValue(Id, out Id);
            Hotel result = new Hotel();

            foreach (var item in AllHotels) {
                if (item.Id.Equals(Id)) {
                    result = item;
                    break;
                }
            }

            return result;
        }

        public float GetPredictionForHotel(string hotelId, string userId) {
            ModelInput sampleData = new ModelInput() {
                Id_user = float.Parse(userId),
                Id_hotel = float.Parse(hotelId)
            };

            var predictionResult = ConsumeModel.Predict(sampleData);

            return predictionResult.Score;
        }

        public Review[] GetTop5Recommendations(string userId) {
            Review[] top5Recommendations = new Review[5];

            ModelInput sampleData = new ModelInput() {
                Id_user = float.Parse(userId)
            };

            for (int i = 0; i < 5; i++) {
                top5Recommendations[i] = new Review();
            }

            foreach (var item in AllHotels) {
                sampleData.Id_hotel = float.Parse(item.Id);

                var predictionResult = ConsumeModel.Predict(sampleData);
                if (predictionResult.Score > 5) {
                    predictionResult.Score = 5;
                }

                Review tempReview = new Review {
                    HotelId = sampleData.Id_hotel,
                    Rating = predictionResult.Score,
                    UserId = sampleData.Id_user
                };

                top5Recommendations = AddRecommendation(tempReview, top5Recommendations);
            }

            return top5Recommendations;
        }

        private Review[] AddRecommendation(Review review, Review[] reviews) {
            Review[] top5Recommendations = reviews;
            Review nextReview = new Review();
            Review currentReview = new Review();

            for (int i = 0; i < top5Recommendations.Length; i++) {
                if (review.HotelId == top5Recommendations[i].HotelId) {
                    break;
                }
                if (review.Rating > top5Recommendations[i].Rating) {
                    currentReview = top5Recommendations[i];
                    top5Recommendations[i] = review;

                    for (int j = i + 1; j < top5Recommendations.Length; j++) {
                        nextReview = top5Recommendations[j];
                        top5Recommendations[j] = currentReview;
                        currentReview = nextReview;
                    }
                    break;
                }
            }

            return top5Recommendations;
        }
    }
}
