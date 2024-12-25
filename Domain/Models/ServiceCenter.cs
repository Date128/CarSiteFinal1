using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель сервисного центра.
public partial class ServiceCenter
{
    /// Уникальный идентификатор сервисного центра.
    public int CenterId { get; set; }

    /// Название сервисного центра.
    public string Name { get; set; } = null!;

    /// Адрес сервисного центра.
    public string Address { get; set; } = null!;

    /// Контактный телефон сервисного центра.
    public string Phone { get; set; } = null!;

    /// Электронная почта сервисного центра.
    public string Email { get; set; } = null!;

    /// Коллекция услуг, предоставляемых сервисным центром.
    public virtual ICollection<MaintenanceService> MaintenanceServices { get; set; } = new List<MaintenanceService>();

    /// Коллекция записей о техническом обслуживании, связанных с сервисным центром.
    public virtual ICollection<TechnicalMaintenance> TechnicalMaintenances { get; set; } = new List<TechnicalMaintenance>();
}