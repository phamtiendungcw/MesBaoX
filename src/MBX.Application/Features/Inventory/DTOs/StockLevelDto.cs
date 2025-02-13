namespace MBX.Application.Features.Inventory.DTOs;

public class StockLevelDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid WarehouseId { get; set; }
    public int QuantityOnHand { get; set; }
    public int QuantityAvailable { get; set; }
    public bool IsActive { get; set; }
}