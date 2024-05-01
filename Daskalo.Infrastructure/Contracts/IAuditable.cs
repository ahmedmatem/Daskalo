namespace Daskalo.Infrastructure.Contracts
{
    public interface IAuditable
    {
        DateTime? CreatedOn { get; set; }

        DateTime? LastModifiedOn { get; set; }
    }
}
