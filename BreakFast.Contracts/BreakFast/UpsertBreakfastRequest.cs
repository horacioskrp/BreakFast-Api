namespace BreakFast.Contracts.BreakFast;
public record UpsertBreakfastRequest(

    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModify,
    List<string> Savory,
    List<string> Sweet
);