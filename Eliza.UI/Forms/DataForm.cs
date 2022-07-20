using Eliza.Model;
using Eliza.Model.Farm;
using Eliza.Model.SaveData;
using Eliza.UI.Widgets;
using Eto.Forms;
using System;

namespace Eliza.UI.Forms
{
    public class DataForm : Form
    {
        private SaveData _saveData;

        public DataForm(SaveData save)
        {
            _saveData = save;

            Title = "Data";

            var data = save.saveData;
            var stackLayout = new VBox()
            {
                HorizontalContentAlignment = HorizontalAlignment.Center,
            };

            var saveFlagButton = new Button()
            {
                Text = "Save Flag"
            };

            saveFlagButton.Click += SaveFlagButton_Click;

            var worldDataButton = new Button()
            {
                Text = "World Data"
            };

            worldDataButton.Click += WorldDataButton_Click;

            var playerDataButton = new Button()
            {
                Text = "Player Data"
            };

            playerDataButton.Click += PlayerDataButton_Click;

            var eventDataButton = new Button()
            {
                Text = "Event Data"
            };

            eventDataButton.Click += EventDataButton_Click;

            var npcDataButton = new Button()
            {
                Text = "NPC Data"
            };

            npcDataButton.Click += NpcDataButton_Click;

            var fishingDataButton = new Button()
            {
                Text = "Fishing Data"
            };

            fishingDataButton.Click += FishingDataButton_Click;

            var stampDataButton = new Button()
            {
                Text = "Stamp Data"
            };

            stampDataButton.Click += StampDataButton_Click;

            var furnitureDataButton = new Button()
            {
                Text = "Furniture Data"
            };

            furnitureDataButton.Click += FurnitureDataButton_Click;

            var battleDataButton = new Button()
            {
                Text = "Battle Data"
            };

            battleDataButton.Click += BattleDataButton_Click;

            var itemDataButton = new Button()
            {
                Text = "Item Data"
            };

            itemDataButton.Click += ItemDataButton_Click;

            var supportMonsterDataButton = new Button()
            {
                Text = "Support Monster Data"
            };

            supportMonsterDataButton.Click += SupportMonsterDataButton_Click;

            var farmDataButton = new Button()
            {
                Text = "Increase Soil Stats"
            };

            farmDataButton.Click += FarmDataButton_Click;

            var statusDataButton = new Button()
            {
                Text = "Max Monster Friendship"
            };

            statusDataButton.Click += StatusDataButton_Click;

            var orderDataButton = new Button()
            {
                Text = "Order Data"
            };

            orderDataButton.Click += OrderDataButton_Click;

            var makingDataButton = new Button()
            {
                Text = "Making Data"
            };

            makingDataButton.Click += MakingDataButton_Click;

            var policeBatchDataButton = new Button()
            {
                Text = "Police Batch Data"
            };

            policeBatchDataButton.Click += PoliceBatchDataButton_Click;

            var itemFlagDataButton = new Button()
            {
                Text = "Item Flag Data"
            };

            itemFlagDataButton.Click += ItemFlagDataButton_Click;

            var buildDataButton = new Button()
            {
                Text = "Build Data"
            };

            buildDataButton.Click += BuildDataButton_Click;

            var shippingDataButton = new Button()
            {
                Text = "Shipping Data"
            };

            shippingDataButton.Click += ShippingDataButton_Click;

            var lPocketDataButton = new Button()
            {
                Text = "LPocket Data"
            };

            lPocketDataButton.Click += LPocketDataButton_Click;

            var nameDataButton = new Button()
            {
                Text = "Name Data"
            };

            nameDataButton.Click += NameDataButton_Click;

            StackLayoutItem[] stackLayoutItems =
            {
                    saveFlagButton,
                    worldDataButton,
                    playerDataButton,
                    eventDataButton,
                    npcDataButton,
                    fishingDataButton,
                    stampDataButton,
                    furnitureDataButton,
                    battleDataButton,
                    itemDataButton,
                    supportMonsterDataButton,
                    farmDataButton,
                    statusDataButton,
                    orderDataButton,
                    makingDataButton,
                    policeBatchDataButton,
                    itemFlagDataButton,
                    buildDataButton,
                    shippingDataButton,
                    lPocketDataButton,
                    nameDataButton
                };
            foreach (var item in stackLayoutItems)
            {
                stackLayout.Items.Add(item);
            }

            Content = stackLayout;
        }

        private void SaveFlagButton_Click(object sender, EventArgs e)
        {
            var saveFlagForm = new SaveFlagForm(_saveData.saveData.saveFlag);
            saveFlagForm.Show();
        }

        private void WorldDataButton_Click(object sender, EventArgs e)
        {
            var worldDataForm = new WorldDataForm(_saveData.saveData.worldData);
            worldDataForm.Show();
        }

        private void PlayerDataButton_Click(object sender, EventArgs e)
        {
            var playerDataForm = new PlayerDataForm(_saveData.saveData.playerData);
            playerDataForm.Show();
        }

        private void EventDataButton_Click(object sender, EventArgs e)
        {
            var eventDataForm = new EventDataForm(_saveData.saveData.eventData);
            eventDataForm.Show();
        }

        private void NpcDataButton_Click(object sender, EventArgs e)
        {
            var npcDataForm = new NPCDataForm(_saveData.saveData.npcData);
            npcDataForm.Show();
        }

        private void FishingDataButton_Click(object sender, EventArgs e)
        {
            var fishingDataForm = new FishingDataForm(_saveData.saveData.fishingData);
            fishingDataForm.Show();
        }

        private void StampDataButton_Click(object sender, EventArgs e)
        {
            var stampDataForm = new StampDataForm(_saveData.saveData.stampData);
            stampDataForm.Show();
        }

        private void FurnitureDataButton_Click(object sender, EventArgs e)
        {
            var furnitureDataForm = new FurnitureDataForm(_saveData.saveData.furnitureData);
            furnitureDataForm.Show();
        }

        private void BattleDataButton_Click(object sender, EventArgs e)
        {
            var battleDataForm = new BattleDataForm(_saveData.saveData.battleData);
            battleDataForm.Show();
        }

        private void ItemDataButton_Click(object sender, EventArgs e)
        {
            var itemDataForm = new ItemDataForm(_saveData.saveData.itemData);
            itemDataForm.Show();
        }

        private void ShippingDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NameDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LPocketDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BuildDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItemFlagDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PoliceBatchDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MakingDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OrderDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StatusDataButton_Click(object sender, EventArgs e)
        {
            this.MaxMonsterFriendship(_saveData.saveData.statusData);
        }

        private void FarmDataButton_Click(object sender, EventArgs e)
        {
            this.MaxSoilStats(_saveData.saveData.farmData);
        }

        private void SupportMonsterDataButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Maxes out the friendship values of all monsters in your barn.
        /// </summary>
        /// <param name="statusData">The current Statusdata from the save file.</param>
        private void MaxMonsterFriendship(RF5StatusData statusData)
        {
            foreach (var monster in statusData.FriendMonsterStatusDatas)
            {
                monster.LovePoint = 255;
            }
        }

        /// <summary>
        /// Kind of maxes out the soil stats. 
        /// Soil stats are stored in four BitVector32 structures. Each structure contains 4 soil values a 8-bytes.
        /// Variables labeled with 'Boost' are the ones the player can influence with items like greenifier.
        /// Variables labeled with 'Lvl' are the experience points of the soil that increase with harvesting. Once they overflow they increase the base values.
        /// Variables labeled with "base" are the base values of the soil.
        /// Other variables kind of influence the other stats in a weird way.
        /// This method only changes Boost and Lvl stats and ignores the others.
        /// </summary>
        /// <param name="farmData">The current farm data from the save file</param>
        private void MaxSoilStats(RF5FarmData farmData)
        {
            foreach (var soil in farmData.Soil)
            {
                
                BitVector32Int soil0 = soil.SI0;
                // grow speed, 11 bits, base value?
                //soil0[FarmManager.si0_grow_spd] = 0x7FF;
                // grow number, 11 bits
                soil0[FarmManager.si0_grow_num] = 0x7FF;
                // grow level, 10 bits
                soil0[FarmManager.si0_grow_lvl] = 0x3FF;

                BitVector32Int soil1 = soil.SI1;
                // grow size, 10 bits, base value?
                //soil1[FarmManager.si1_grow_size] = 0x3FF;
                // def, 6 bits
                soil1[FarmManager.si1_def] = 0x3F;
                // hp, 8 bits
                soil1[FarmManager.si1_hp] = 0xFF;
                // atk, 5 bits, don't know what this is for. what does the soil attack?
                //soil1[FarmManager.si1_atk] = 0x1F;
                // doping, 2 bits, don't know what it is
                //soil1[FarmManager.si1_doping] = 3;
                // work_on_crop, 1 bit, don't know what it is
                //soil1[FarmManager.si1_work_on_crop] = 1;
                
                BitVector32Int soil2 = soil.SI2;
                // rp, 4 bits, don't know what this is for
                //soil2[FarmManager.si2_rp] = 0xF;
                // soil_num_lvl, 4 bits
                soil2[FarmManager.si2_soil_num_lvl] = 0xF;
                // soil_lvl_lvl, 4 bits
                soil2[FarmManager.si2_soil_lvl_lvl] = 0xF;
                // soil_size_lvl, 4 bits
                soil2[FarmManager.si2_soil_size_lvl] = 0xF;
                // soil_exp, 8 bits
                soil2[FarmManager.si2_soil_exp] = 0xFF;
                // soil_spd_exp, 8 bits
                soil2[FarmManager.si2_soil_spd_exp] = 0xFF;

                BitVector32Int soil3 = soil.SI3;
                // soil_num_exp, 8 bits
                soil3[FarmManager.si3_soil_num_exp] = 0xFF;
                // soil_lvl_xp, 8 bits
                soil3[FarmManager.si3_soil_lvl_exp] = 0xFF;
                // soil_size_exp, 8 bits
                soil3[FarmManager.si3_soil_size_exp] = 0xFF;
                // soil_lvl, 4 bits
                soil3[FarmManager.si3_soil_lvl] = 0xF;
                // soil_spd_lvl, 4 bits
                soil3[FarmManager.si3_soil_spd_lvl] = 0xF;
            }
        }
    }
}
