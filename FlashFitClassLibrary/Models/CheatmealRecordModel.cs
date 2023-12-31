﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashFitClassLibrary.Models;


public class CheatmealRecordModel
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CheatmealRecordID { get; set; }

    [ForeignKey(nameof(CheatmealModel))]
    public int CheatmealId { get; set; }
    public CheatmealModel Cheatmeal { get; set; }

    [ForeignKey("fk_useremail")]
    public string UserEmail { get; set; }

    public DateTime CheatmealRecordedDateTime { get; set; }

    [Column(TypeName = "decimal(18,4)")]
    public decimal WeightAtMealRecordTime { get; set; }
    public DateTime CheatmealAddedDateTime { get; set; }
    public DateTime CheatmealUpdatedDateTime { get; set; }

}
