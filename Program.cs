using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Life.ApiPharm
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            #region token
            string jwtToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxNzIiLCJqdGkiOiI5MmEzZDkzYWVhNjQ5NWM4MjkyOTY3MmYyMTA1NTcyZjU2YTg0Yjc5M2NiMWQwNWNlZGQ2M2VkMThhNmRiNmQ0YTgxOTA1YmQ3YzU1MmZhMyIsImlhdCI6MTcxMzI4MDM3OC41MjI2MzcsIm5iZiI6MTcxMzI4MDM3OC41MjI2NCwiZXhwIjoxNzEzMzY2Nzc4LjQ0NjU1NCwic3ViIjoiIiwic2NvcGVzIjpbImdybHM6cmVhZCIsImdybHM6cmVhZF9oaXN0b3JpY2FsIiwidW46cmVhZCIsInVuOnJlYWRfd2l0aF9wa3UiLCJ2bWw6cmVhZCIsInduZjpyZWFkIiwidm1sX2xpbTpyZWFkIiwicnpuOnJlYWQiLCJyZWFkOnBoYXJtaWQ6ZHJ1Z3MiLCJyZWFkOnJlbChwaGFybWlkOmRydWdzfHZtbDpwcmljZXMpIiwicmVhZDpyZWwocGhhcm1pZDpkcnVnc3wqOnBrdSkiLCJyZWFkOnJlbChwaGFybWlkOmRydWdzfHduZjppdGVtcykiLCJyZWFkOnJlbChwaGFybWlkOmRydWdzfHJ6bjppdGVtcykiLCJyZWFkOnJlbChwaGFybWlkOmRydWdzfGdybHM6aXRlbXMpIiwicmVhZDpyZWwocGhhcm1pZDpkcnVnc3xncmxzOmluc3RydWN0aW9uX3NjYW5zKSJdfQ.O07f4_Yngx2c9l6wlYdOKn0HMitCqbK-6mZw_JCSuvL3bSCqa4uZV_nGzjCT2D3YkfmYLJFNEszF8gowLEQ3pbe0PSPht6BVPSWLXndhUcZ0Kjsy-q0UnUyYF-UrIKIZx5x57k0JSDzgyKsjLbIOVsDZNyCFjEyslRdayh-ksh9JohnEaRjz2TeO9zi-qfA5kQNhm9kskBhgFUCjS7I3bKIf2gN_uEle2C41eSaId0m9O7Kwfg1HOJJ7z29BLE97QX7CP_FlNHXs5C-g-wMiLzywr0hG63WmjQt0J72PeooTB_c9ljS7xoVCoUT__nYQjfCXsu6c71xBLn0Wq9eeO7gGf5PONCFYvJz-sAuc1n3xSvsNnFUCTKYM791Vzn6uXs0WBxQXgf4j9fXBWInLbjwuNOWfdlQoDUmN3E0_WSYW73VuS8r4CyoSR_R9ZVfG7D6OzoOLZlE7A0E7LLkod3WR2KRlil6NT79vnyoiztE79fOjHtJjrLkDLpsiwAXOP9ghENo2jg3J_v_mOXYEb2r0DflrZCgmxLcX5bIa54qY8Qnaxgtkfk5iw_qRSW_Kf12S8wZ_cmEDLFtfYkgM-wBtbf8SOso2ltFoTnGwfHe4SwcSo5vgfg3E8QDGVFU_wrcLB-fqwRIeXRtONPZe_w2ojl8buGmkjK28x7j2Myg";
            #endregion

            // Путь к файлу JSON с данными grls_id
            string fileNameDataIds = "dataIds.json";
            string filePathDataIds = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameDataIds);


            // Считываем JSON из файла
            string json = File.ReadAllText(filePathDataIds);

            // Преобразуем JSON в список объектов ListGrlsId
            List<ListGrlsId> listGrlsIds = JsonConvert.DeserializeObject<List<ListGrlsId>>(json);

            // Список для хранения всех данных
            List<RootObject> allData = new List<RootObject>();

            // API endpoint для получения данных
            string apiUrl = "https://api.pharm-portal.ru/grls/certnums/{grls_id}/raw";

            // Создаем RestClient
            var restClient = new RestClient();

            bool flag = false;

            int count = 0;

            // Перебираем все ListGrlsId
            foreach (var item in listGrlsIds)
            {
                if (item.data != null)
                {
                    // Перебираем все данные внутри ListGrlsId
                    foreach (var dataItem in item.data)
                    {
                        count += 1;
                        if (dataItem.grls_id == "571705e0-c6ff-435f-ae2d-d3dc0ff8d52d") // начать с ..
                        {
                            flag = true;
                        }

                        if (flag)
                        {
                            // Формируем URL для запроса данных по grls_id
                            string requestUrl = apiUrl.Replace("{grls_id}", dataItem.grls_id);

                            // Создаем RestRequest
                            var request = new RestRequest(requestUrl);

                            request.AddHeader("Authorization", $"Bearer {jwtToken}");

                            // Выполняем запрос и получаем ответ
                            var response = await restClient.ExecuteAsync(request);

                            if (response.IsSuccessful)
                            {
                                // Десериализуем JSON в объект RootObject
                                RootObject grlsData = JsonConvert.DeserializeObject<RootObject>(response.Content);
                                grlsData.id_grls = dataItem.grls_id;
                                //Console.WriteLine(grlsData.TradeName);

                                await SaveData(grlsData);



                            }
                            else
                            {
                                Console.WriteLine($"Ошибка при получении данных для grls_id {dataItem.grls_id}: {response}");
                                break;
                            }

                            // Ждем некоторое время перед отправкой следующего запроса (чтобы не нагружать сервер)
                            await Task.Delay(1000);
                        }
                    }
                }
            }

            Console.WriteLine("Все данные получены");

            Console.ReadKey();

        }

        public static async Task SaveData(RootObject rootObject)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                GRLS grls = new GRLS
                {
                    ptg = string.Join(" ; ", rootObject.Ptg),
                    id_grls = rootObject.id_grls,
                    Inn = rootObject.Inn,
                    IsFs = rootObject.IsFs,
                    CertNum = rootObject.CertNum,
                    ExpDate = rootObject.ExpDate,
                    RegDate = rootObject.RegDate,
                    RenewDate = rootObject.RenewDate,
                    TradeName = rootObject.TradeName,
                    CancelDate = rootObject.CancelDate,
                    HolderName = rootObject.HolderName,
                    IsNarcotic = rootObject.IsNarcotic,
                    OrphanDate = rootObject.OrphanDate,
                    HolderCountry = rootObject.HolderCountry,
                    IsLifeImportant = rootObject.IsLifeImportant,
                    CirculationPeriod = rootObject.CirculationPeriod,
                    IsInterchangeable = rootObject.IsInterchangeable,

                };
                dbContext.GRLS.Add(grls);

                foreach (var atgItem in rootObject.Atg)
                {
                    AtgItemDb atgItemDb = new AtgItemDb
                    {
                        Grls = grls,
                        Code = atgItem.Code,
                        Name = atgItem.Name,
                    };
                    dbContext.AtgItems.Add(atgItemDb);
                }

                foreach (var instruction in rootObject.Instructions)
                {
                    InstructionDb instructionDb = new InstructionDb
                    {
                        Grls = grls,
                        Url = instruction.Url,
                        IdReg = instruction.IdReg,
                        Label = instruction.Label,
                        Section = instruction.Section,
                        Filename = instruction.Filename,
                        SourceUrl = instruction.SourceUrl,
                        SourceName = instruction.SourceName,
                        InstructionLabel = instruction.Label,
                        InstructionFolderPath = instruction.InstructionFolderPath,
                    };
                    dbContext.Instructions.Add(instructionDb);
                }

                foreach (var manufacturingForm in rootObject.ManufacturingForm)
                {
                    ManufacturingFormDb manufacturingFormDb = new ManufacturingFormDb
                    {
                        Grls = grls,
                        Dose = manufacturingForm.Dose,
                        Form = manufacturingForm.Form,
                        ShelfLife = manufacturingForm.ShelfLife,
                        StorageConditions = manufacturingForm.StorageConditions,
                    };
                    dbContext.ManufacturingForms.Add(manufacturingFormDb);

                    foreach (var pack in manufacturingForm.Packs)
                    {
                        Pack packdb = new Pack
                        {
                            ManufacturingForm = manufacturingFormDb,
                            Name = pack,
                        };
                        dbContext.Packs.Add(packdb);
                    }
                }



                foreach (var manufacturingInfo in rootObject.ManufacturingInfo)
                {
                    ManufacturingInfoDb manufacturingInfoDb = new ManufacturingInfoDb
                    {
                        Grls = grls,
                        Stage = manufacturingInfo.Stage,
                        Number = manufacturingInfo.Number,
                        Address = manufacturingInfo.Address,
                        Country = manufacturingInfo.Country,
                        Manufacturer = manufacturingInfo.Manufacturer,
                    };
                    dbContext.ManufacturingInfos.Add(manufacturingInfoDb);
                }

                foreach (var normativeDoc in rootObject.NormativeDoc)
                {
                    NormativeDocDb normativeDocDb = new NormativeDocDb
                    {
                        Grls = grls,
                        Year = normativeDoc.Year,
                        Title = normativeDoc.Title,
                        Number = normativeDoc.Number,
                        DocNumber = normativeDoc.DocNumber,
                        ChangeNumber = normativeDoc.ChangeNumber,
                    };
                    dbContext.NormativeDocs.Add(normativeDocDb);
                }

                foreach (var pharmaceuticalSubstance in rootObject.PharmaceuticalSubstance)
                {
                    PharmaceuticalSubstanceDb pharmaceuticalSubstanceDb = new PharmaceuticalSubstanceDb
                    {
                        Grls = grls,
                        Inn = pharmaceuticalSubstance.Inn,
                        Address = pharmaceuticalSubstance.Address,
                        CertNum = pharmaceuticalSubstance.CertNum,
                        ShelfLife = pharmaceuticalSubstance.ShelfLife,
                        TradeName = pharmaceuticalSubstance.TradeName,
                        Manufacturer = pharmaceuticalSubstance.Manufacturer,
                        DrugsPresence = pharmaceuticalSubstance.DrugsPresence,
                        StorageConditions = pharmaceuticalSubstance.StorageConditions,

                    };
                    dbContext.PharmaceuticalSubstances.Add(pharmaceuticalSubstanceDb);
                }

                // Сохранить изменения в базе данных
                await dbContext.SaveChangesAsync();


                // JOIN и вывод в консоль
                //var query = from instruction in dbContext.Instructions
                //            join g in dbContext.GRLS on instruction.GrlsId equals g.id
                //            join atgItem in dbContext.AtgItems on g.id equals atgItem.GrlsId
                //            select new
                //            {
                //                Instruction = instruction,
                //                GRLS = g,
                //                AtgItem = atgItem
                //            };

                //foreach (var item in query)
                //{
                //    Console.WriteLine($"Instruction: {item.Instruction.Url}, GRLS: {item.GRLS.id_grls}, AtgItem: {item.AtgItem.Name}");
                //}

            }
        }
    }

}



