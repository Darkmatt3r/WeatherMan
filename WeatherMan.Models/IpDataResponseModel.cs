using System;
using System.Runtime.Serialization;

namespace WeatherMan.Models
{
    [DataContract]
    public class IPDataResponseModel
    {
        [DataMember(Name = "ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Returns true if the country is a recognized member of the
        /// European Unions
        /// </summary>
        [DataMember(Name = "is_eu")]
        public bool IsEu { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// The 3 letter ISO 3166-2 code for the region.
        /// </summary>
        [DataMember(Name = "region_code")]
        public string RegionCode { get; set; }

        [DataMember(Name = "country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// The 2 letter ISO 3166-1 alpha-2 code for the country
        /// </summary>
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        [DataMember(Name = "continent_name")]
        public string ContinentName { get; set; }

        /// <summary>
        /// The 2 letter ISO 3166-1 alpha-2 code for the continent. 
        /// One of; AF, AN, AS, EU, NA, OC, SA
        /// </summary>
        [DataMember(Name = "continent_code")]
        public string ContinentCode { get; set; }

        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// The Autonomous System Number that references the IP Address's owning organization.
        /// </summary>
        [DataMember(Name = "asn")]
        public string Asn { get; set; }

        [DataMember(Name = "organization")]
        public string Organization { get; set; }

        [DataMember(Name = "postal")]
        public string PostalCode { get; set; }

        [DataMember(Name = "calling_code")]
        public string CallingCode { get; set; }

        [DataMember(Name = "flag")]
        public Uri Flag { get; set; }

        [DataMember(Name = "emoji_flag")]
        public string EmojiFlag { get; set; }

        [DataMember(Name = "emoji_unicode")]
        public string EmojiUnicode { get; set; }

        /// <summary>
        /// A JSON object with details of the IP Addresses's carrier.
        /// </summary>
        [DataMember(Name = "carrier")]
        public Carrier Carrier { get; set; }

        [DataMember(Name = "languages")]
        public Language[] Languages { get; set; }

        /// <summary>
        /// A JSON object with details of the IP Address country's main currency.
        /// </summary>
        [DataMember(Name = "currency")]
        public Currency Currency { get; set; }

        /// <summary>
        /// A JSON object with details of the Timezone the IP Address belongs to.
        /// </summary>
        [DataMember(Name = "time_zone")]
        public TimeZone TimeZone { get; set; }

        [DataMember(Name = "threat")]
        public Threat Threat { get; set; }
    }

    public class Carrier
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The Mobile Country Code of the carrier.
        /// </summary>
        [DataMember(Name = "mcc")]
        public string MCC { get; set; }

        /// <summary>
        /// The Mobile Network Code that identifies the carrier.
        /// </summary>
        [DataMember(Name = "mnc")]
        public string MNC { get; set; }
    }

    [DataContract]
    public class Language
    {
       
    }

    [DataContract]
    public class Currency
    {
        /// <summary>
        /// The name of the currency.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The symbol of the currency.
        /// </summary>
        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// The native symbol of the currency.
        /// </summary>
        [DataMember(Name = "native")]
        public string Native { get; set; }

        /// <summary>
        /// The plural version of the currency. For example; US dollars, Australian dollars, Euros
        /// </summary>
        [DataMember(Name = "plural")]
        public string Plural { get; set; }
    }

    public class TimeZone
    {
        /// <summary>
        /// The name of the Timezone Eg. "America/Los_Angeles"
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The Abbreviation of the Timezone Eg. "PDT"
        /// </summary>
        [DataMember(Name = "abbr")]
        public string Abbr { get; set; }

        /// <summary>
        /// The UTC offset of the Timezone Eg. "-0700"
        /// </summary>
        [DataMember(Name = "offset")]
        public int Offset { get; set; }

        /// <summary>
        /// true or false depending on whether or not Daylight Savings have been accounted for.
        /// </summary>
        [DataMember(Name = "is_dst")]
        public bool IsDst { get; set; }

        /// <summary>
        /// The exact current time in the Timezone the IP Address
        /// belongs to accounting for Daylight Savings.
        /// </summary>
        [DataMember(Name = "current_time")]
        public DateTime CurrentTime { get; set; }
    }

    public class Threat
    {
        /// <summary>
        /// true or false depending on whether the IP Address is a known Tor exit node or relay.
        /// </summary>
        [DataMember(Name = "is_tor")]
        public bool IsTor { get; set; }

        /// <summary>
        /// true or false depending on whether the IP Address is a known proxy or any type.
        /// </summary>
        [DataMember(Name = "is_proxy")]
        public bool IsProxy { get; set; }

        /// <summary>
        /// true or false depending on whether is_tor or is_proxy is true.
        /// </summary>
        [DataMember(Name = "is_anonymous")]
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// true or false if the IP Address is a known (reported) source of malicious activity.
        /// </summary>
        [DataMember(Name = "is_known_attacker")]
        public bool IsKnownAttacker { get; set; }

        /// <summary>
        /// true or false if the IP Address is a known (reported) source of abuse.
        /// </summary>
        [DataMember(Name = "is_known_abuser")]
        public bool IsKnownAbuser { get; set; }

        /// <summary>
        /// true or false depending on whether is_known_abuser or is_known_attacker is true.
        /// </summary>
        [DataMember(Name = "is_threat")]
        public bool IsThreat { get; set; }

        /// <summary>
        /// true or false if the IP Address is a Bogon i.e. an unassigned, unaddressable IP address
        /// </summary>
        [DataMember(Name = "is_bogon")]
        public bool IsBogon { get; set; }
    }    
}
