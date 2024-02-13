using TAX.Models;

namespace TAX.ApiService
{
    public interface ITaxService
    {
        /// <summary>
        /// Получает данные о организации из Апи налогой
        /// </summary>
        /// <param name="unp">Унп по которой искать орг</param>
        /// <returns>Данные о организаци</returns>
        public Task<Tax> GetTaxByUNP(string unp);
    }
}