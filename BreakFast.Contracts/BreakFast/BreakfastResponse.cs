namespace BreakFast.Contracts.BreakFast;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModify,
    List<string> Savory,
    List<string> Sweet
);