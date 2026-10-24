using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class PropriedadePokemon
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Ability
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability ability { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Animated
    {
        public string front_default { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class BlackWhite
    {
        public Animated animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class BrilliantDiamondShiningPearl
    {
        public Icons icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Champions
    {
        public Icons icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Cries
    {
        public string latest { get; set; }
        public string legacy { get; set; }
    }

    public class Crystal
    {
        public Animated animated { get; set; }
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_shiny_transparent { get; set; }
        public string front_shiny_transparent { get; set; }
    }

    public class DiamondPearl
    {
        public Animated animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class DreamWorld
    {
        public object front_female { get; set; }
        public string front_default { get; set; }
    }

    public class Emerald
    {
        public Animated animated { get; set; }
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class FireredLeafgreen
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndex
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GenerationI
    {
        [JsonProperty("red-and-blue")]
        public RedAndBlue redandblue { get; set; }

        [JsonProperty("red-and-green")]
        public RedAndGreen redandgreen { get; set; }
        public Yellow yellow { get; set; }

        [JsonProperty("red-blue")]
        public RedBlue redblue { get; set; }

        [JsonProperty("red-green-japan")]
        public RedGreenJapan redgreenjapan { get; set; }
    }

    public class GenerationIi
    {
        [JsonProperty("gold-and-silver")]
        public GoldAndSilver goldandsilver { get; set; }
        public Gold gold { get; set; }
        public Silver silver { get; set; }
        public Crystal crystal { get; set; }
    }

    public class GenerationIii
    {
        public Icons icons { get; set; }
        public Emerald emerald { get; set; }

        [JsonProperty("ruby-sapphire")]
        public RubySapphire rubysapphire { get; set; }

        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen { get; set; }
    }

    public class GenerationIv
    {
        public Icons icons { get; set; }
        public Platinum platinum { get; set; }

        [JsonProperty("diamond-pearl")]
        public DiamondPearl diamondpearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
    }

    public class GenerationIx
    {
        public Champions champions { get; set; }

        [JsonProperty("legends-za")]
        public LegendsZa legendsza { get; set; }

        [JsonProperty("scarlet-violet")]
        public ScarletViolet scarletviolet { get; set; }
    }

    public class GenerationV
    {
        public Icons icons { get; set; }

        [JsonProperty("black-white")]
        public BlackWhite blackwhite { get; set; }
    }

    public class GenerationVi
    {
        [JsonProperty("x-y")]
        public XY xy { get; set; }
        public Icons icons { get; set; }

        [JsonProperty("omega-ruby-alpha-sapphire")]
        public OmegaRubyAlphaSapphire omegarubyalphasapphire { get; set; }
    }

    public class GenerationVii
    {
        public Icons icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultrasunultramoon { get; set; }

        [JsonProperty("lets-go-pikachu-lets-go-eevee")]
        public LetsGoPikachuLetsGoEevee letsgopikachuletsgoeevee { get; set; }
    }

    public class GenerationViii
    {
        [JsonProperty("sword-shield")]
        public SwordShield swordshield { get; set; }

        [JsonProperty("legends-arceus")]
        public LegendsArceus legendsarceus { get; set; }

        [JsonProperty("brilliant-diamond-shining-pearl")]
        public BrilliantDiamondShiningPearl brilliantdiamondshiningpearl { get; set; }
    }

    public class Gold
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_shiny_transparent { get; set; }
        public string front_shiny_transparent { get; set; }
    }

    public class GoldAndSilver
    {
        public object front_default { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        public Animated animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class HeldItem
    {
        public Item item { get; set; }
        public List<VersionDetail> version_details { get; set; }
    }

    public class Home
    {
        public string front_shiny { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons
    {
        public Animated animated { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public object front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class LegendsArceus
    {
        public Icons icons { get; set; }
        public object back_shiny { get; set; }
        public object back_female { get; set; }
        public object front_shiny { get; set; }
        public object back_default { get; set; }
        public object front_female { get; set; }
        public object front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class LegendsZa
    {
        public Icons icons { get; set; }
        public object back_shiny { get; set; }
        public object back_female { get; set; }
        public object front_shiny { get; set; }
        public object back_default { get; set; }
        public object front_female { get; set; }
        public object front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class LetsGoPikachuLetsGoEevee
    {
        public Icons icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Move
    {
        public Move move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class OfficialArtwork
    {
        public Versions versions { get; set; }
        public string front_shiny { get; set; }
        public string front_default { get; set; }
    }

    public class OmegaRubyAlphaSapphire
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Other
    {
        public Home home { get; set; }
        public Showdown showdown { get; set; }
        public DreamWorld dream_world { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }
    }

    public class PastAbility
    {
        public Generation generation { get; set; }
        public List<Ability> abilities { get; set; }
    }

    public class PastStat
    {
        public Generation generation { get; set; }
        public List<Stat> stats { get; set; }
    }

    public class Platinum
    {
        public Animated animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class RedAndBlue
    {
        public string front_default { get; set; }
    }

    public class RedAndGreen
    {
        public string front_default { get; set; }
    }

    public class RedBlue
    {
        public string back_gray { get; set; }
        public string front_gray { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_transparent_gray { get; set; }
        public string front_transparent_gray { get; set; }
    }

    public class RedGreenJapan
    {
        public string back_gray { get; set; }
        public string front_gray { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        public List<Ability> abilities { get; set; }
        public List<PastAbility> past_abilities { get; set; }
        public List<Form> forms { get; set; }
        public List<GameIndex> game_indices { get; set; }
        public List<HeldItem> held_items { get; set; }
        public string location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public Cries cries { get; set; }
        public List<Stat> stats { get; set; }
        public List<PastStat> past_stats { get; set; }
        public List<Type> types { get; set; }
        public List<object> past_types { get; set; }
    }

    public class RubySapphire
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class ScarletViolet
    {
        public Icons icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Showdown
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Silver
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_shiny_transparent { get; set; }
        public string front_shiny_transparent { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Sprites
    {
        public Other other { get; set; }
        public Versions versions { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat stat { get; set; }
    }

    public class Stat2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class SwordShield
    {
        public Icons icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type type { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class UltraSunUltraMoon
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionDetail
    {
        public int rarity { get; set; }
        public Version version { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public VersionGroup version_group { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public object order { get; set; }
    }

    public class Versions
    {
        [JsonProperty("generation-i")]
        public GenerationI generationi { get; set; }

        [JsonProperty("generation-ii")]
        public GenerationIi generationii { get; set; }

        [JsonProperty("generation-v")]
        public GenerationV generationv { get; set; }

        [JsonProperty("generation-iv")]
        public GenerationIv generationiv { get; set; }

        [JsonProperty("generation-ix")]
        public GenerationIx generationix { get; set; }

        [JsonProperty("generation-vi")]
        public GenerationVi generationvi { get; set; }

        [JsonProperty("generation-iii")]
        public GenerationIii generationiii { get; set; }

        [JsonProperty("generation-vii")]
        public GenerationVii generationvii { get; set; }

        [JsonProperty("generation-viii")]
        public GenerationViii generationviii { get; set; }
    }

    public class XY
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Yellow
    {
        public string back_gbc { get; set; }
        public string back_gray { get; set; }
        public string front_gbc { get; set; }
        public string front_gray { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_transparent_gray { get; set; }
        public string front_transparent_gray { get; set; }
    }


    }
}