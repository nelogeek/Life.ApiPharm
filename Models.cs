using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.ApiPharm
{
    public class Datum
    {
        public string? grls_id { get; set; }
        public string? cert_num { get; set; }
        public string? trade_name { get; set; }
    }

    public class ListGrlsId
    {
        public List<Datum>? data { get; set; }
    }

    // ------------------------------------------


    public class AtgItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Instruction
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("idReg")]
        public int IdReg { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("section")]
        public int Section { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("instruction_label")]
        public string InstructionLabel { get; set; }

        [JsonProperty("instruction_folder_path")]
        public string InstructionFolderPath { get; set; }
    }

    public class ManufacturingForm
    {
        [JsonProperty("dose")]
        public string Dose { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("packs")]
        public List<string> Packs { get; set; }

        [JsonProperty("shelf_life")]
        public string ShelfLife { get; set; }

        [JsonProperty("storage_conditions")]
        public string StorageConditions { get; set; }
    }

    public class ManufacturingInfo
    {
        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }
    }

    public class NormativeDoc
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("doc_number")]
        public string DocNumber { get; set; }

        [JsonProperty("change_number")]
        public string ChangeNumber { get; set; }
    }

     public class PharmaceuticalSubstance
    {
        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("cert_num")]
        public string CertNum { get; set; }

        [JsonProperty("shelf_life")]
        public string ShelfLife { get; set; }

        [JsonProperty("trade_name")]
        public string TradeName { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("drugs_presence")]
        public string DrugsPresence { get; set; }

        [JsonProperty("storage_conditions")]
        public string StorageConditions { get; set; }
    }

    public class RootObject
    {
        public string id_grls { get; set; }

        [JsonProperty("atg")]
        public List<AtgItem> Atg { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("ptg")]
        public List<string> Ptg { get; set; }

        [JsonProperty("is_fs")]
        public bool IsFs { get; set; }

        [JsonProperty("is_ref")]
        public string IsRef { get; set; }

        [JsonProperty("cert_num")]
        public string CertNum { get; set; }

        [JsonProperty("exp_date")]
        public string ExpDate { get; set; }

        [JsonProperty("reg_date")]
        public string RegDate { get; set; }

        [JsonProperty("ref_links")]
        public List<string> RefLinks { get; set; }

        [JsonProperty("renew_date")]
        public string RenewDate { get; set; }

        [JsonProperty("trade_name")]
        public string TradeName { get; set; }

        [JsonProperty("cancel_date")]
        public string CancelDate { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("is_narcotic")]
        public string IsNarcotic { get; set; }

        [JsonProperty("orphan_date")]
        public string OrphanDate { get; set; }

        [JsonProperty("instructions")]
        public List<Instruction> Instructions { get; set; }

        [JsonProperty("normative_doc")]
        public List<NormativeDoc> NormativeDoc { get; set; }

        [JsonProperty("holder_country")]
        public string HolderCountry { get; set; }

        [JsonProperty("is_life_important")]
        public string IsLifeImportant { get; set; }

        [JsonProperty("circulation_period")]
        public string CirculationPeriod { get; set; }

        [JsonProperty("is_interchangeable")]
        public string IsInterchangeable { get; set; }

        [JsonProperty("manufacturing_form")]
        public List<ManufacturingForm> ManufacturingForm { get; set; }

        [JsonProperty("manufacturing_info")]
        public List<ManufacturingInfo> ManufacturingInfo { get; set; }

        [JsonProperty("pharmaceutical_substance")]
        public List<PharmaceuticalSubstance> PharmaceuticalSubstance { get; set; }
    }

    // -----------------------------

    public class GRLS
    {
        [Key]
        public int id { get; set; }

        public string? id_grls { get; set; }
        public string? ptg { get; set; }

        //public List<AtgItem> Atg { get; set; }
        public string? Inn { get; set; }
        //public List<string> Ptg { get; set; }
        public bool? IsFs { get; set; }
        //public string IsRef { get; set; }
        public string? CertNum { get; set; }
        public string? ExpDate { get; set; }
        public string? RegDate { get; set; }
        //public List<string> RefLinks { get; set; }
        public string? RenewDate { get; set; }
        public string? TradeName { get; set; }
        public string? CancelDate { get; set; }
        public string? HolderName { get; set; }
        public string? IsNarcotic { get; set; }
        public string? OrphanDate { get; set; }
        //public List<Instruction> Instructions { get; set; }
        //public List<NormativeDoc> NormativeDoc { get; set; }
        public string? HolderCountry { get; set; }
        public string? IsLifeImportant { get; set; }
        public string? CirculationPeriod { get; set; }
        public string? IsInterchangeable { get; set; }
        //public List<ManufacturingForm> ManufacturingForm { get; set; }
        //public List<ManufacturingInfo> ManufacturingInfo { get; set; }
        //public List<PharmaceuticalSubstance> PharmaceuticalSubstance { get; set; }
    }


    public class PharmaceuticalSubstanceDb
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на GRLS
        public int GrlsId { get; set; }
        [ForeignKey("GrlsId")]
        public GRLS Grls { get; set; }


        public string? Inn { get; set; }
        public string? Address { get; set; }
        public string? CertNum { get; set; }
        public string? ShelfLife { get; set; }
        public string? TradeName { get; set; }
        public string? Manufacturer { get; set; }
        public string? DrugsPresence { get; set; }
        public string? StorageConditions { get; set; }
    }

    public class NormativeDocDb
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на GRLS
        public int GrlsId { get; set; }
        [ForeignKey("GrlsId")]
        public GRLS Grls { get; set; }


        public string? Year { get; set; }
        public string? Title { get; set; }
        public string? Number { get; set; }
        public string? DocNumber { get; set; }
        public string? ChangeNumber { get; set; }
    }

    public class ManufacturingInfoDb
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на GRLS
        public int GrlsId { get; set; }
        [ForeignKey("GrlsId")]
        public GRLS Grls { get; set; }


        public string? Stage { get; set; }
        public string? Number { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? Manufacturer { get; set; }
    }

    public class ManufacturingFormDb
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на GRLS
        public int GrlsId { get; set; }
        [ForeignKey("GrlsId")]
        public GRLS Grls { get; set; }


        public string? Dose { get; set; }
        public string? Form { get; set; }
        //public string? Packs { get; set; }
        public string? ShelfLife { get; set; }
        public string? StorageConditions { get; set; }
    }

    public class Pack
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на ManufacturingFormDb
        public int ManufacturingFormId { get; set; }
        [ForeignKey("ManufacturingFormId")]
        public ManufacturingFormDb ManufacturingForm { get; set; }


        public string? Name { get; set; }

    }

    public class InstructionDb
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на GRLS
        public int GrlsId { get; set; }
        [ForeignKey("GrlsId")]
        public GRLS Grls { get; set; }


        public string? Url { get; set; }
        public int? IdReg { get; set; }
        public string? Label { get; set; }
        public int? Section { get; set; }
        public string? Filename { get; set; }
        public string? SourceUrl { get; set; }
        public string? SourceName { get; set; }
        public string? InstructionLabel { get; set; }
        public string? InstructionFolderPath { get; set; }
    }

    public class AtgItemDb
    {
        [Key]
        public int id { get; set; }
        // Вторичный ключ на GRLS
        public int GrlsId { get; set; }
        [ForeignKey("GrlsId")]
        public GRLS Grls { get; set; }


        public string? Code { get; set; }
        public string? Name { get; set; }
    }







}
