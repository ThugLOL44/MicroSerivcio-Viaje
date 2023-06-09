﻿using Application.Request;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IServices
{
    public interface IViajeServices
    {
        ViajeResponse CreateViaje(ViajeRequest viajeRequest);
        IEnumerable<ViajeResponse> GetAllViajes();
        ViajeResponse GetViajeById(int viajeId);
        ViajeResponse AddViaje(Viaje viaje);
        ViajeResponse UpdateViaje(int viajeId, ViajeRequest viajeRequest);
        ViajeResponse DeleteViaje(int viajeId);
    }
}
