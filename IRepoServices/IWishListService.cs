using ClothingAPIs.Models;
using ClothingAPIs.NewFolder;

namespace ClothingAPIs.IRepoServices
{
	public interface IWishListService
	{
		public void Create(int ProdId, string userId);


		public void DeleteWishList(int ProdId, string userId);
		public List<int> GetWishListByUserId(string userId);

	}
}
