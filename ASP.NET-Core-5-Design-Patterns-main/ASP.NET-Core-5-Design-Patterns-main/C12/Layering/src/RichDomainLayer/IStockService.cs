﻿namespace RichDomainLayer
{
    public interface IStockService
    {
        int AddStock(int productId, int amount);
        int RemoveStock(int productId, int amount);
    }
}