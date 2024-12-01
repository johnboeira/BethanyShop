using BethanysPieShopHRM.Shared.Domain;

namespace BethanyShop.Services;

public interface IJobCategoryDataService
{
    Task<IEnumerable<JobCategory>> GetAllJobCategories();

    Task<JobCategory> GetJobCategoryById(int jobCategoryId);
}