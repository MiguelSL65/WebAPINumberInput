using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIInput.Models
{
    /**
     * The number model entity
     */
    public class InputNumber
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Num { get; set; }
    }
}
