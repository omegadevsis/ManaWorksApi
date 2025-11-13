namespace ManaWorksVacancy.Application.Dtos.Vacancies;

public class UpdateVacancyDto
{
    public int VacancyId { get; set; }
    public int WorkTypeId { get; set; }
    public int ContractTypeId { get; set; }
    public int JourneyTypeId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Requirements { get; set; }
    public DateTime Date { get; set; }
    public string Hour { get; set; }
    public DateTime OpenDate { get; set; }
    public DateTime CloseDate { get; set; }
    public string Status { get; set; }
}