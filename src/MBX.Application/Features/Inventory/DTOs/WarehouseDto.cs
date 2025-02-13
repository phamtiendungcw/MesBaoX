namespace MBX.Application.Features.Inventory.DTOs
{
    public class WarehouseDto
    {
        public Guid Id { get; set; }
        public string WarehouseName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
