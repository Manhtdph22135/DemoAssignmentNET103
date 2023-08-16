using System;
using System.Collections.Generic;

namespace A_DAL.A_DAL.Models;

public partial class TaiSan
{
    public int MaTaiSan { get; set; }

    public string TenTaiSan { get; set; } = null!;

    public DateTime? NgayMua { get; set; }

    public double? GiaMua { get; set; }

    public short? MaLoaiTs { get; set; }

    public string? TinhTrang { get; set; }

    public string? TrangThaiSd { get; set; }
}
