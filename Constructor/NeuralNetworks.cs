//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Constructor
{
    using System;
    using System.Collections.Generic;
    
    public partial class NeuralNetworks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NeuralNetworks()
        {
            this.NeuralNetworks_LearningResults = new HashSet<NeuralNetworks_LearningResults>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Owner { get; set; }
        public Nullable<int> Dataset { get; set; }
        public int InputNeuronsCount { get; set; }
        public int OutputNeuronsCount { get; set; }
        public string MiddleLayers { get; set; }
        public bool Bias { get; set; }
        public int ActivationFunction { get; set; }
        public Nullable<int> CostFunction { get; set; }
        public string SerializedString { get; set; }
    
        public virtual ActivationFunctions ActivationFunctions { get; set; }
        public virtual CostFunctions CostFunctions { get; set; }
        public virtual Datasets Datasets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NeuralNetworks_LearningResults> NeuralNetworks_LearningResults { get; set; }
        public virtual Users Users { get; set; }
    }
}
