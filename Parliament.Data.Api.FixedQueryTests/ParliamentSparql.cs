﻿namespace Parliament.Data.Api.FixedQuery.Controllers.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Parliament.Data.Api.FixedQuery.Controllers;
    using Parliament.Data.Api.FixedQueryTests;

    [TestClass()]
    [TestCategory("Parliament")]
    [TestCategory("Sparql")]
    public class ParliamentSparql : SparqlValidator
    {
        private ParliamentController controller;

        [TestInitialize]
        public void Initialize()
        {
            controller = new ParliamentController();
        }

        [TestMethod()]
        public void ParliamentIndexSparql()
        {
            ValidateSparql(() => controller.Index());
        }

        [TestMethod()]
        public void ParliamentCurrentSparql()
        {
            ValidateSparql(() => controller.Current());
        }

        [TestMethod()]
        public void ParliamentPreviousSparql()
        {
            ValidateSparql(() => controller.Previous());
        }

        [TestMethod()]
        public void ParliamentNextSparql()
        {
            ValidateSparql(() => controller.Next());
        }

        [TestMethod()]
        public void ParliamentLookupSparql()
        {
            ValidateSparql(() => controller.Lookup(null, null));
        }

        [TestMethod()]
        public void ParliamentByIdSparql()
        {
            ValidateSparql(() => controller.ById(null));
        }

        [TestMethod()]
        public void ParliamentNextByIdSparql()
        {
            ValidateSparql(() => controller.Next(null));
        }

        [TestMethod()]
        public void ParliamentMembersSparql()
        {
            ValidateSparql(() => controller.Members(null));
        }

        [TestMethod()]
        public void ParliamentMembersByInitialSparql()
        {
            ValidateSparql(() => controller.MembersByInitial(null, null));
        }

        [TestMethod()]
        public void ParliamentMembersAToZSparql()
        {
            ValidateSparql(() => controller.MembersAToZLetters(null));
        }

        [TestMethod()]
        public void ParliamentMembersHousesSparql()
        {
            ValidateSparql(() => controller.MembersHouses(null));
        }

        [TestMethod()]
        public void ParliamentMembersHouseSparql()
        {
            ValidateSparql(() => controller.MembersHouse(null, null));
        }

        [TestMethod()]
        public void ParliamentMembersHouseAToZSparql()
        {
            ValidateSparql(() => controller.MembersHouseAToZLetters(null, null));
        }

        [TestMethod()]
        public void ParliamentMemberHouseByInitialSparql()
        {
            ValidateSparql(() => controller.MembersHouseByInitial(null, null, null));
        }

        [TestMethod()]
        public void ParliamentPartiesSparql()
        {
            ValidateSparql(() => controller.Parties(null));
        }

        [TestMethod()]
        public void ParliamentPartySparql()
        {
            ValidateSparql(() => controller.Party(null, null));
        }

        [TestMethod()]
        public void ParliamentPartyMembersSparql()
        {
            ValidateSparql(() => controller.PartyMembers(null, null));
        }

        [TestMethod()]
        public void ParliamentPartyMembersAToZSparql()
        {
            ValidateSparql(() => controller.PartyMembersAToZLetters(null, null));
        }

        [TestMethod()]
        public void ParliamentPartyMembersByInitialSparql()
        {
            ValidateSparql(() => controller.PartyMembersByInitial(null, null, null));
        }

        [TestMethod()]
        public void ParliamentPartyHousesSparql()
        {
            ValidateSparql(() => controller.PartyHouses(null, null));
        }

        [TestMethod()]
        public void ParliamentPartyHouseSparql()
        {
            ValidateSparql(() => controller.PartyHouse(null, null, null));
        }

        [TestMethod()]
        public void ParliamentPartyHouseMembersSparql()
        {
            ValidateSparql(() => controller.PartyHouseMembers(null, null, null));
        }

        [TestMethod()]
        public void ParliamentPartyHouseMembersAToZSparql()
        {
            ValidateSparql(() => controller.PartyHouseMembersAToZLetters(null, null, null));
        }

        [TestMethod()]
        public void ParliamentPartyHouseMembersByInitialSparql()
        {
            ValidateSparql(() => controller.PartyHouseMembersByInitial(null, null, null, null));
        }

        [TestMethod()]
        public void ParliamentConstituenciesSparql()
        {
            ValidateSparql(() => controller.Constituencies(null));
        }

        [TestMethod()]
        public void ParliamentConstituenciesAToZSparql()
        {
            ValidateSparql(() => controller.ConstituenciesAToZLetters(null));
        }

        [TestMethod()]
        public void ParliamentConstituenciesByInitialSparql()
        {
            ValidateSparql(() => controller.ConstituenciesByInitial(null, null));
        }
    }
}