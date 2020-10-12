﻿using Promotion_Engine_SCM_CT_v1009.Models;

namespace Promotion_Engine_SCM_CT_v1009.Core.Interfaces
{
    public interface ICartActions
    {
        /// <summary>
        /// Used to append a SKU to a cart
        /// </summary>
        /// <param name="sku">The SKU to be added</param>
        void Add(SKUEnum sku);

        /// <summary>
        /// Used to remove a SKU from a cart
        /// </summary>
        /// <param name="sku">The SKU to be removed</param>
        void Remove(SKUEnum sku);

        /// <summary>
        /// Get the size of the Cart
        /// </summary>
        /// <returns></returns>
        int Size();
    }
}