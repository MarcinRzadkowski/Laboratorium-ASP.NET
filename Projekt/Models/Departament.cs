using System.ComponentModel.DataAnnotations;

public enum Departament
{
    [Display(Name = "Księgowość")] Accounting,
    [Display(Name = "HR")] HumanResources,
    [Display(Name = "IT")] IT,
    [Display(Name = "Sprzedaż")] Sales,
    [Display(Name = "Reklama")] Marketing,
    [Display(Name = "Administracja")] Operations,
    [Display(Name = "Wsparcie klienta")] ClientSupport
}
