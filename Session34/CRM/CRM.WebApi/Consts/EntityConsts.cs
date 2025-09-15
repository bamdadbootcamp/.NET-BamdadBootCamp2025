namespace CRM.WebApi.Consts;

public class EntityConsts
{
    public static readonly (int MaxLength, int MinLength) USER_USERNAME = (100, 3);
    public static readonly (int MaxLength, int MinLength) USER_PASSWORD = (125, 8);
}