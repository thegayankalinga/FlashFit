using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashFitUserManagementService;

namespace FlashFitClassLibrary.Models;

public class WorkoutRecordModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WorkoutRecordId { get; set; }

    [ForeignKey(nameof(WorkoutModel))]
    public int WorkoutTypeId { get; set; }
    public WorkoutModel WorkoutModel { get; init; }

    [ForeignKey("FK_WorkouRecord_UserEmail")]
    public string UserEmail { get; set; }

    public DateTime WorkedoutDateTime { get; set; }

    [Column(TypeName = "decimal(18,4)")]
    public decimal WeightAtCompletion { get; set; }
    public DateTime WorkoutRecordAddedDateTime { get; set; }
    public DateTime? WorkoutRecordUpdatedDateTime { get; set; }

}
