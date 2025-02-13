namespace MBX.Application.Features.Inventory.DTOs;

public class StockMovementDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid WarehouseId { get; set; }
    public string MovementType { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public DateTime MovementDate { get; set; }
    public bool IsActive { get; set; }
}