using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель продажи автомобиля.
public partial class CarSale
{
    /// Уникальный идентификатор продажи.
    public int SaleId { get; set; }

    /// Идентификатор автомобиля, связанного с продажей.
    public int? CarId { get; set; }

    /// Идентификатор продавца (пользователя).
    public int? SellerId { get; set; }

    /// Идентификатор покупателя (пользователя).
    public int? BuyerId { get; set; }

    /// Дата продажи автомобиля.
    public DateTime? SaleDate { get; set; }

    /// Цена продажи автомобиля.
    public decimal Price { get; set; }

    /// Статус продажи (например, "Завершено", "В процессе", "Отменено").
    public string Status { get; set; } = null!;

    /// Навигационное свойство для связи с покупателем (пользователем).
    public virtual User? Buyer { get; set; }

    /// Навигационное свойство для связи с автомобилем.
    public virtual Car? Car { get; set; }

    /// Навигационное свойство для связи с продавцом (пользователем).
    public virtual User? Seller { get; set; }
}