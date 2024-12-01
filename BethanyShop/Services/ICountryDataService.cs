using BethanysPieShopHRM.Shared.Domain;

namespace BethanyShop.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();

        Task<Country> GetCountryById(int countryId);
    }
}