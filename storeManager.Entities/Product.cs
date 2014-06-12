//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace storeManager.Entities
{
    public partial class Product
    {
        #region Primitive Properties
    
        public virtual string Barcode
        {
            get;
            set;
        }
    
        public virtual string ProductName
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual int Quantity
        {
            get;
            set;
        }
    
        public virtual decimal UnitPrice
        {
            get;
            set;
        }
    
        public virtual int CategoryID
        {
            get { return _categoryID; }
            set
            {
                if (_categoryID != value)
                {
                    if (Category != null && Category.CategoryID != value)
                    {
                        Category = null;
                    }
                    _categoryID = value;
                }
            }
        }
        private int _categoryID;
    
        public virtual Nullable<System.DateTime> ManufactureDate
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> ExpiryDate
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ReorderLevel
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> PurchasePrice
        {
            get;
            set;
        }
    
        public virtual decimal SellingPrice
        {
            get;
            set;
        }
    
        public virtual byte[] ProductImage
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> OnSale
        {
            get;
            set;
        }
    
        public virtual int SupplierID
        {
            get { return _supplierID; }
            set
            {
                if (_supplierID != value)
                {
                    if (Supplier != null && Supplier.SupplierID != value)
                    {
                        Supplier = null;
                    }
                    _supplierID = value;
                }
            }
        }
        private int _supplierID;
    
        public virtual string ProductNum
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Commission
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Discount
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> DateAdded
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LastDateAdjusted
        {
            get;
            set;
        }
    
        public virtual string EmployeeID
        {
            get;
            set;
        }
    
        public virtual int BrandID
        {
            get { return _brandID; }
            set
            {
                if (_brandID != value)
                {
                    if (Brand != null && Brand.BrandID != value)
                    {
                        Brand = null;
                    }
                    _brandID = value;
                }
            }
        }
        private int _brandID;
    
        public virtual string AdjustmentReason
        {
            get;
            set;
        }
    
        public virtual int ProductID
        {
            get;
            set;
        }
    
        public virtual int LocationID
        {
            get;
            set;
        }
    
        public virtual int MeasurementID
        {
            get { return _measurementID; }
            set
            {
                if (_measurementID != value)
                {
                    if (Measurement != null && Measurement.Id != value)
                    {
                        Measurement = null;
                    }
                    _measurementID = value;
                }
            }
        }
        private int _measurementID;

        #endregion
        #region Navigation Properties
    
        public virtual Brand Brand
        {
            get { return _brand; }
            set
            {
                if (!ReferenceEquals(_brand, value))
                {
                    var previousValue = _brand;
                    _brand = value;
                    FixupBrand(previousValue);
                }
            }
        }
        private Brand _brand;
    
        public virtual Category Category
        {
            get { return _category; }
            set
            {
                if (!ReferenceEquals(_category, value))
                {
                    var previousValue = _category;
                    _category = value;
                    FixupCategory(previousValue);
                }
            }
        }
        private Category _category;
    
        public virtual Supplier Supplier
        {
            get { return _supplier; }
            set
            {
                if (!ReferenceEquals(_supplier, value))
                {
                    var previousValue = _supplier;
                    _supplier = value;
                    FixupSupplier(previousValue);
                }
            }
        }
        private Supplier _supplier;
    
        public virtual ICollection<ProductLocation> ProductLocations
        {
            get
            {
                if (_productLocations == null)
                {
                    var newCollection = new FixupCollection<ProductLocation>();
                    newCollection.CollectionChanged += FixupProductLocations;
                    _productLocations = newCollection;
                }
                return _productLocations;
            }
            set
            {
                if (!ReferenceEquals(_productLocations, value))
                {
                    var previousValue = _productLocations as FixupCollection<ProductLocation>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupProductLocations;
                    }
                    _productLocations = value;
                    var newValue = value as FixupCollection<ProductLocation>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupProductLocations;
                    }
                }
            }
        }
        private ICollection<ProductLocation> _productLocations;
    
        public virtual Measurement Measurement
        {
            get { return _measurement; }
            set
            {
                if (!ReferenceEquals(_measurement, value))
                {
                    var previousValue = _measurement;
                    _measurement = value;
                    FixupMeasurement(previousValue);
                }
            }
        }
        private Measurement _measurement;

        #endregion
        #region Association Fixup
    
        private void FixupBrand(Brand previousValue)
        {
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Brand != null)
            {
                if (!Brand.Products.Contains(this))
                {
                    Brand.Products.Add(this);
                }
                if (BrandID != Brand.BrandID)
                {
                    BrandID = Brand.BrandID;
                }
            }
        }
    
        private void FixupCategory(Category previousValue)
        {
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Category != null)
            {
                if (!Category.Products.Contains(this))
                {
                    Category.Products.Add(this);
                }
                if (CategoryID != Category.CategoryID)
                {
                    CategoryID = Category.CategoryID;
                }
            }
        }
    
        private void FixupSupplier(Supplier previousValue)
        {
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Supplier != null)
            {
                if (!Supplier.Products.Contains(this))
                {
                    Supplier.Products.Add(this);
                }
                if (SupplierID != Supplier.SupplierID)
                {
                    SupplierID = Supplier.SupplierID;
                }
            }
        }
    
        private void FixupMeasurement(Measurement previousValue)
        {
            if (previousValue != null && previousValue.Products.Contains(this))
            {
                previousValue.Products.Remove(this);
            }
    
            if (Measurement != null)
            {
                if (!Measurement.Products.Contains(this))
                {
                    Measurement.Products.Add(this);
                }
                if (MeasurementID != Measurement.Id)
                {
                    MeasurementID = Measurement.Id;
                }
            }
        }
    
        private void FixupProductLocations(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ProductLocation item in e.NewItems)
                {
                    item.Product = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProductLocation item in e.OldItems)
                {
                    if (ReferenceEquals(item.Product, this))
                    {
                        item.Product = null;
                    }
                }
            }
        }

        #endregion
    }
}