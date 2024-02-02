﻿using System;

namespace Exercise10
{
    class Program
    {
		private static VideoStore store = new VideoStore();
		private static RatingManager ratingManager = new RatingManager();
		
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
				Console.WriteLine("Choose 5 to give a rating");
				Console.WriteLine("Choose 6 to view ratings");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
						break;
					case 5:
                        AddNewRating();
                        break;
					case 6:
                        ViewRatings();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void FillVideoStore()
        {
			store.AddVideo("Matrix");
			store.AddVideo("Godfather II");
			store.AddVideo("Star Wars Episode IV: A New Hope");
        }

        private static void RentVideo()
        {
			store.CheckOutVideo(Console.ReadLine());
        }

        private static void ReturnVideo()
        {
			bool returnVideo = store.ReturnVideo(Console.ReadLine());
        }

		private static void ListInventory()
        {
			store.ListInventory();
        }

		private static void AddNewRating()
        {
			ratingManager.AddNewRating();
        }

		private static void ViewRatings()
        {
			ratingManager.ViewRatings();
        }
    }
}