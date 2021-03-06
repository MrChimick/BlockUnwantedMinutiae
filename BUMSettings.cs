﻿using System;
using System.Collections.Generic;
using RimWorld;
using Verse;
using UnityEngine;
using Verse.Sound;

namespace BlockUnwantedMinutiae
{
    public class BUMSettings : ModSettings
    {
        public static IReadOnlyList<string> genericMessage_labels { get; } = new string[]
        {
            // Messages.xml
            "MessageSiegersAssaulting",
            "MessageRaidersBeginningAssault",
            "MessageRaidersDetectedEarlyAssault",
            "MessageRaidersKidnapping",
            "MessageRaidersStealing",
            "MessageCaravanDetectedRaidArrived",
            "MessageRaidersLeaving",
            "MessageRaidersGivenUpLeaving",
            "MessageRaidersSatisfiedLeaving",
            "MessageFightersFleeing",
            "MessageFriendlyFightersLeaving",
            "MessageVisitorsTakingWounded",
            "MessageVisitorsTrappedLeaving",
            "MessageVisitorsDangerousTemperature",
            "MessageWornApparelDeterioratedAway",
            "MessageDeterioratedAway",
            "MessageSeasonBegun",
            "MessageShipHasLeftCommsRange",
            "MessageNeedBeaconToTradeWithShip",
            "MessageNeedRoyalTitleToCallWithShip",
            "MessageConditionCauserDespawned",
            "MessageBillComplete",
            "MessageFullyHealed",
            "MessagePrisonerIsEscaping",
            "MessageOutOfNearbyShellsFor",
            "MessageAnimalsGoPsychoHunted",
            "MessageAnimalManhuntsOnTameFailed",
            "MessageRecruitSuccess",
            "MessageTameSuccess",
            "MessageTameAndNameSuccess",
            "MessageRecruitJoinOfferAccepted",
            "MessageColonyCannotAfford",
            "MessageColonyNotEnoughSilver",
            "MessageCriticalAlert",
            "MessageMustDesignateHarvestable",
            "MessageMustDesignateHarvestableWood",
            "MessageMustDesignatePlants",
            "MessageMustDesignateHaulable",
            "MessageMustDesignateMineable",
            "MessageMustDesignateHuntable",
            "MessageMustDesignateTameable",
            "MessageMustDesignateClaimable",
            "MessageMustDesignateDeconstructibleMechCluster",
            "MessageMustDesignateSmoothableSurface",
            "MessageNothingCanRemoveThickRoofs",
            "MessageAlreadyInStorage",
            "MessageMustDesignateStrippable",
            "MessageMustDesignateSlaughterable",
            "MessageMustDesignateOpenable",
            "MessageMustDesignateForbiddable",
            "MessageMustDesignateUnforbiddable",
            "MessageRefusedArrest",
            "MessageNoMedicalBeds",
            "MessageNoAnimalBeds",
            "MessageTooLowMedCare",
            "PawnDiedBecauseOf",
            "PawnDied",
            "MessageNoLongerDowned",
            "MessageInvoluntarySleep",
            "MessageMedicalOperationWillAngerFaction",
            "MessageMiscarriedStarvation",
            "MessageMiscarriedPoorHealth",
            "MessageGaveBirth",
            "MessagePsylinkNoSensitivity",
            "MessageLostImplantLevelFromHediff",
            "MessageReceivedBrainDamageFromHediff",
            "MessageWentOverPsychicEntropyLimit",
            "MessageNuzzledPawnGaveNameTo",
            "MessageNoHandlerSkilledEnough",
            "MessageEatenByPredator",
            "MessageAttackedByPredator",
            "MessageHiveReproduced",
            "MessageTraderCaravanLeaving",
            "MessageCantSelectDeadPawn",
            "MessageCantSelectOffMapPawn",
            "MessageSocialFight",
            "MessageNewMarriageCeremony",
            "MessageMarriageCeremonyStarts",
            "MessageMarriageCeremonyCalledOff",
            "MessageNewlyMarried",
            "MessageMarriageCeremonyAfterPartyFinished",
            "MessageNewBondRelation",
            "MessageNewBondRelationNewName",
            "MessageBondedAnimalMentalBreak",
            "MessageNamedBondedAnimalMentalBreak",
            "MessageBondedAnimalsMentalBreak",
            "MessageSuccessfullyRemovedHediff",
            "MessageShipChunkDrop",
            "MessageCannotSellItemsReason",
            "MessageConstructionFailed",
            "MessageScreenshotSavedAs",
            "MessageNoLongerSocialFighting",
            "MessageNoLongerBingingOnDrug",
            "MessageNoLongerOnTargetedInsultingSpree",
            "MessageRottedAwayInStorage",
            "MessageFoodPoisoning",
            "MessagePawnLostWhileFormingCaravan",
            "MessagePawnLostWhileFormingCaravan_AllLost",
            "MessageCaravanFormationPaused",
            "MessageCaravanFormationUnpaused",
            "MessageCaravanMemberHasExtremeMentalBreak",
            "MessageMaxPlanetCoveragePerformanceWarning",
            "MessagePlantDiedOfCold",
            "MessagePlantDiedOfRot_LeftUnharvested",
            "MessagePlantDiedOfRot_ExposedToLight",
            "MessagePlantDiedOfRot",
            "MessagePlantDiedOfPoison",
            "MessagePlantDiedOfBlight",
            "MessagePawnBeingBurned",
            "MessageAccidentalOverdose",
            "MessageCaravanArrivedAtDestination",
            "MessagePawnLeftMapAndCreatedCaravan",
            "MessagePawnLeftMapAndCreatedCaravan_AnimalsWantToJoin",
            "MessageSettledInExistingMap",
            "MessagePermanentWoundHealed",
            "MessageRescueeDidntJoin",
            "MessageTransporterUnreachable",
            "MessageTransportersNotAdjacent",
            "MessageTransportersLoadCanceled_TransporterDestroyed",
            "MessageTransporterSingleLoadCanceled_TransporterDestroyed",
            "MessageTransportersLoadCanceled_FuelingPortGiverDeSpawned",
            "MessageTransportersLoadingProcessStarted",
            "MessageTransporterSingleLoadingProcessStarted",
            "MessageTransportPodsArrived",
            "MessageTransportPodsArrivedAndLost",
            "MessageTransportPodsArrivedAndAddedToCaravan",
            "MessageFinishedLoadingTransporters",
            "MessageFinishedLoadingTransporterSingle",
            "MessageCantLoadMoreIntoTransporters",
            "MessageTransportPodsDestinationIsInvalid",
            "MessageTransportPodsDestinationIsTooFar",
            "MessageReformedCaravan",
            "MessageCantBanishLastColonist",
            "MessageCantEquipCustom",
            "MessageCantEquipIncapableOfViolence",
            "MessageCantEquipIncapableOfManipulation",
            "MessageCantWearApparelMissingBodyParts",
            "MessageCantUnequipLockedApparel",
            "MessageWouldReplaceLockedApparel",
            "MessageSlaughteringBondedAnimal",
            "MessageCaravanRanOutOfFood",
            "MessageCaravanDeathCorpseAddedToInventory",
            "MessageSelectOwnBaseToFormCaravan",
            "MessageScreenResTooSmallForUIScale",
            "MessageYouHaveToReformCaravanNow",
            "MessageDefendersAttacking",
            "MessageMechanoidsAssembled",
            "MessageMechanoidsLeftToAssemble",
            "MessageMechanoidsReinforcementsDrop",
            "MessageSelfTendUnsatisfied",
            "MessageCannotSelfTendEver",
            "MessageCantAddWaypointBecauseImpassable",
            "MessageCantAddWaypointBecauseUnreachable",
            "MessageCantAddWaypointBecauseLimit",
            "MessageCantRemoveWaypointBecauseFirst",
            "MessageCantDoExecutionBecauseNoWardenCapableOfViolence",
            "MessageSiteCountdownBecauseNoMoreEnemies",
            "MessageSiteCountdownBecauseNoEnemiesInitially",
            "MessageCantBanishDownedPawn",
            "MessageSleepingPawnsWokenUp",
            "MessageMechClusterDefeated",
            "MessageCompSpawnerSpawnedItem",
            "MessageHediffCuredByItem",
            "MessageBodyPartCuredByItem",
            "MessageResearchProjectFinishedByItem",
            "MessagePawnResurrected",
            "MessageFailedToRescueRelative",
            "MessageRescuedRelative",
            "MessageTornadoLeftMap",
            "MessageTornadoDissipated",
            "MessagePeaceTalksNoDiplomat",
            "MessageWarningCavePlantsExposedToLight",
            "MessageTargetedTantrumChangedTarget",
            "MessageTargetedInsultingSpreeChangedTarget",
            "MessageMurderousRageChangedTarget",
            "MessagePlantIncompatibleWithRoof",
            "MessageRoofIncompatibleWithPlant",
            "MessagePlayerTriedToLeaveMapViaExitGrid_CanReform",
            "MessagePlayerTriedToLeaveMapViaExitGrid_CantReform",
            "MessageGoodwillChanged",
            "MessageGoodwillChangedWithReason",
            "MessageGiftGivenButNotAppreciated",
            "MessageCantGiveGiftBecauseCantCarryEncumbered",
            "MessageCantGiveGiftBecauseCantCarry",
            "MessageFormedCaravan",
            "MessageFormedCaravan_Orders",
            "MessageBillValidationStoreZoneDeleted",
            "MessageBillValidationStoreZoneUnavailable",
            "MessageBillValidationPawnUnavailable",
            "MessageBillValidationIncludeZoneDeleted",
            "MessageBillValidationIncludeZoneUnavailable",
            "MessageBillValidationStoreZoneInsufficient",
            "MessageAnimalReturnedWild",
            "MessageAnimalLostSkill",
            "MessageTranslationReportSaved",
            "MessageCaravanArrivalActionNoLongerValid",
            "MessageEnterCooldownBlocksEntering",
            "MessagePermitCooldownFinished",
            "MessagePredatorHuntingPlayerAnimal",
            "MessagePrisonerResistanceBroken",
            "MessagePrisonerResistanceBroken_RecruitAttempsWillBegin",
            "MessageModWithPackageIdAlreadyEnabled",
            "MessageDisableModsBeforeCleaningTranslationFiles",
            "MessageUnpackBeforeCleaningTranslationFiles",
            "MessageTranslationFilesCleanupDone",
            "MessageCantCleanupTranslationFilesBeucaseOfXmlError",
            "MessageCapturingWillAngerFaction",
            "MessageStrippingWillAngerFaction",
            "MessageCantShootInMelee",
            "MessageNoColonistCanAcceptQuest",
            "MessageCannotAcceptQuest",
            "MessageQuestAccepted",
            "MessagePawnLeaving",
            "MessagePawnsLeaving",
            "MessageMonumentDestroyedBecauseOfDisallowedBuilding",
            "MessageNoResearchBenchForTechprint",
            "NoValidDestinationFound",
            "MessageResearchMenuWithoutBench",
            "MessageActivatorProximityTriggered",
            "MessageCannotSelectInvisibleStat",
            "MessagePrisonerCannotEquipWeapon",
            // FloatMenu.xml
            "NoPrisonerBed",
            "NoNonPrisonerBed",
            "NoAnimalBed",
            // Inspirations.xml
            "MessageEndedInspireWorkFrenzy",
            "MessageEndedInspireGoFrenzy",
            "MessageEndedInspireShootFrenzy",
            "MessageEndedInspireTrade",
            "MessageEndedInspireRecruitment",
            "MessageEndedInspireTaming",
            "MessageEndedInspireSurgery",
            "MessageEndedInspireCreativity",
            // Hediffs_Global_Misc.xml
            "MessagePregnant",
            "MessageOverdose",
            // GameConditions_Misc.xml
            "MessageSolarFlare",
            "MessageEclipse",
            "MessagePsychicDrone",
            "MessagePsychicSoothe",
            "MessageToxicFallout",
            "MessageVolcanicWinter",
            "MessageHeatWave",
            "MessageColdSnap",
            "MessageFlashstorm",
            "MessageAurora"
        };

        public static IReadOnlyList<string> genericAlert_labels { get; } = new string[]
        {
            "BreakRiskMinor",
            "BreakRiskMajor",
            "BreakRiskExtreme",
            "AlertTatteredApparel",
            "AlertUnhappyNudity",
            "ActivatorCountdown",
            "PatientsAwaitingMedicalOperation",
            "BestowerWaitingAlert",
            "BilliardsNeedsSpace",
            "Boredom",
            "BrawlerHasRangedWeapon",
            "BuildingCantBeUsedRoofed",
            "CaravanIdle",
            "AlertColonistLeftUnburied",
            "ColonistNeedsRescue",
            "ColonistNeedsTreatment",
            "ColonistsIdle",
            "DisallowedBuildingInsideMonument",
            "Exhaustion",
            "FireInHomeArea",
            "AlertHeatstroke",
            "HunterHasShieldAndRangedWeapon",
            "HunterLacksWeapon",
            "AlertHypothermia",
            "ImmobileCaravan",
            "PawnsWithLifeThreateningDisease",
            "LowFood",
            "LowMedicine",
            "MonumentMarkerMissingBlueprints",
            "NeedBatteries",
            "NeedColonistBeds",
            "NeedDefenses",
            "NeedDoctor",
            "NeedJoySource",
            "NeedMealSource",
            "NeedMeditationSpotAlert",
            "NeedMiner",
            "NeedResearchProject",
            "NeedWarden",
            "NeedWarmClothes",
            "NeedFoodHopper",
            "PermitChoiceReadyAlert",
            "QuestExpiresSoon",
            "RoyalNoAcceptableFood",
            "NeedThroneAssigned",
            "ShieldUserHasRangedWeapon",
            "ShipLandingBeaconUnusable",
            "StarvationAnimals",
            "Starvation",
            "ThroneroomInvalidConfiguration",
            "NeedBedroomAssigned",
            "UndignifiedBedroom",
            "UndignifiedThroneroom",
            "UnusableMeditationFocusAlert",
            "QuestPartMoodBelowThreshold",
            "QuestPartShuttleArriveDelay",
            "QuestPartShuttleLeaveDelay"
        };
        
        public static IReadOnlyList<string> genericLetter_labels { get; } = new string[]
        {
            // Letters.xml
            "LetterLabelFirstSummerWarning",
            "LetterLabelAreaRevealed",
            "LetterLabelRoofCollapsed",
            "LetterLabelMessageRecruitSuccess",
            "LetterLabelBirthday",
            "LetterLabelNewDisease",
            "LetterLabelAncientShrineWarning",
            "StruckMineable",
            "LetterLabelAnimalManhunterRevenge",
            "LetterFriendlyTrapSprungLabel",
            "LetterHealthComplicationsLabel",
            "LetterHediffFromRandomHediffGiverLabel",
            "LetterLeadersDeathLabel",
            "LetterLeaderChangedLabel",
            "LetterLabelNoticedRelatedPawns",
            "LetterLabelAffair",
            "LetterLabelNewLovers",
            "LetterLabelBreakup",
            "LetterLabelAcceptedProposal",
            "LetterLabelRejectedProposal",
            "LetterLabelRelationsChange_Hostile",
            "LetterLabelRelationsChange_Ally",
            "LetterLabelRelationsChange_NeutralFromHostile",
            "LetterLabelRelationsChange_NeutralFromAlly",
            "LetterLabelShortCircuit",
            "LetterLabelSuffixBondedAnimalDied",
            "LetterLabelPrisonBreak",
            "LetterLabelNewlyAddicted",
            "LetterLabelDrugBinge",
            "LetterLabelAllCaravanColonistsDied",
            "LetterLabelCaravanEnteredMap",
            "LetterLabelCaravanEnteredEnemyBase",
            "LetterLabelTransportPodsLandedInEnemyBase",
            "LetterLabelFactionBaseDefeated",
            "LetterLabelDefeatAllEnemiesQuestCompleted",
            "LetterLabelFoundPreciousLump",
            "LetterLabelDeepScannerFoundLump",
            "LetterLabelAmbushInExistingMap",
            "LetterLabelPeaceTalks_Disaster",
            "LetterLabelPeaceTalks_Backfire",
            "LetterLabelPeaceTalks_TalksFlounder",
            "LetterLabelPeaceTalks_Success",
            "LetterLabelPeaceTalks_Triumph",
            "LetterLabelAICoreOffer",
            "LetterCraftedLegendaryLabel",
            "LetterCraftedMasterworkLabel",
            "LetterLabelPawnsLostBecauseMapClosed_Caravan",
            "LetterLabelPawnsLostBecauseMapClosed_Home",
            "LetterLabelHibernateComplete",
            "LetterLabelVisitorsGaveGift",
            "LetterLabelFactionBaseProximity",
            "LetterLabelCaravansBattlefieldVictory",
            "LetterLabelRescueQuestFinished",
            "LetterLabelPredatorHuntingColonist",
            "LetterLabelTraitDisease",
            "LetterLabelSurgeryFailed",
            "LetterLabelQuestDropPodsArrived",
            "LetterLabelRefugeeJoins",
            "LetterLabelRescueeJoins",
            "LetterLabelPawnsArriveAndJoin",
            "LetterLabelPawnsArrive",
            "LetterLabelPawnLeaving",
            "LetterLabelPawnsLeaving",
            "LetterLabelPawnsKidnapped",
            "LetterTechprintAppliedLabel",
            "LetterQuestCompletedLabel",
            "LetterQuestFailedLabel",
            "LetterQuestConcludedLabel",
            "LetterBladelinkWeaponBondedLabel",
            "LetterLabelMechClusterArrived",
            "LetterLabelSiteCountdownStarted",
            // Incidents.xml
            "LetterLabelAnimalInsanitySingle",
            "LetterLabelAnimalInsanityMultiple",
            "LetterLabelCropBlight",
            "LetterLabelMiracleHeal",
            "LetterLabelRefugeePodCrash",
            "LetterLabelCargoPodCrash",
            "LetterLabelSingleVisitorArrives",
            "LetterLabelGroupVisitorsArrive",
            "LetterLabelManhunterPackArrived",
            "LetterLabelPsychicDroneLevelIncreased",
            "LetterLabelAgentRevealed",
            "LetterLabelBeaversArrived",
            "LetterLabelAnimalSelfTame",
            "LetterLabelFarmAnimalsWanderIn",
            "LetterLabelThrumboPasses",
            "LetterLabelTraderCaravanArrival",
            "EscapeShipFoundLabel",
            "EscapeShipLostLabel",
            "LetterLabelCaravanRequest",
            "LetterLabelSiteNoLongerHostile",
            "LetterLabelSiteNoLongerHostileMulti",
            "LetterLabelQuestAskerFactionHostile",
            "LetterLabelQuestAskerCaptured",
            "LetterLabelQuestAskerDied",
            // Custom aggregated defs
            // RaidStrategies.xml
            "LetterLabelRaidEnemy",
            "LetterLabelRaidFriendly",
            // Incidents_Caravan_All.xml
            "LetterLabelCaravanAmbush",
            "LetterLabelCaravanManhunter",
            // Incidents_Map_Disease.xml
            "LetterLabelDiseaseFlu",
            "LetterLabelDiseasePlague",
            "LetterLabelDiseaseMalaria",
            "LetterLabelDiseaseSleeping",
            "LetterLabelDiseaseFibrous",
            "LetterLabelDiseaseSensory",
            "LetterLabelDiseaseGutWorms",
            "LetterLabelDiseaseMuscle",
            "LetterLabelDiseaseAnimalFlu",
            "LetterLabelDiseaseAnimalPlague",
            // Incidents_Map_Misc.xml
            "LetterLabelAmbrosiaSprout",
            "LetterLabelWandererJoins",
            "LetterLabelRansom",
            "LetterLabelMeteorite",
            "LetterLabelAnimalMigration",
            "LetterLabelWanderer",
            "LetterLabelToxicFallout",
            "LetterLabelVolcanicWinter",
            "LetterLabelHeatWave",
            "LetterLabelColdSnap",
            "LetterLabelFlashstorm",
            // Incidents_Map_Special.xml
            "LetterLabelManInBlack",
            // Incidents_Map_Threats.xml
            "LetterLabelInfestation",
            "LetterLabelDrillInfestation",
            "LetterLabelDefoliatorShip",
            "LetterLabelPsychicShip",
            "LetterLabelMechCluster",
            // Incidents_World_Conditions.xml
            "LetterLabelEclipse",
            "LetterLabelSolarFlare",
            "LetterLabelAurora",
            // Incidents_World_Quests.xml
            "LetterLabelQuestAvailable",
            "LetterLabelJourneyOffer",
            // Inspirations.xml
            "LetterLabelInspiredWorkFrenzy",
            "LetterLabelInspiredGoFrenzy",
            "LetterLabelInspiredShootFrenzy",
            "LetterLabelInspiredTrade",
            "LetterLabelInspiredRecruitment",
            "LetterLabelInspiredTaming",
            "LetterLabelInspiredSurgery",
            "LetterLabelInspiredCreativity",
            // Hediffs_Global_Misc.xml
            "LetterLabelPregnant",
            "LetterLabelOverdose",
            // GameConditions_Misc.xml
            "LetterLabelSolarFlare",
            "LetterLabelEclipse",
            "LetterLabelPsychicDrone",
            "LetterLabelPsychicSoothe",
            "LetterLabelToxicFallout",
            "LetterLabelVolcanicWinter",
            "LetterLabelHeatWave",
            "LetterLabelColdSnap",
            "LetterLabelFlashstorm",
            "LetterLabelClimateCycle",
            "LetterLabelPlanetkiller",
            "LetterLabelAurora"
        };

        public bool[] genericMessage_values = new bool[genericMessage_labels.Count];
        public bool[] genericAlert_values = new bool[genericAlert_labels.Count];
        public bool[] genericLetter_values = new bool[genericLetter_labels.Count];

        public bool taintedMessagePatch = true;
        public bool idleColonistsPatch = true;
        public bool drawAutoSelectCheckboxPatch = true;

        public override void ExposeData()
        {
            for (int i = 0; i < genericMessage_labels.Count; i++)
            {
                Scribe_Values.Look(ref genericMessage_values[i], genericMessage_labels[i]);
            }
            for (int i = 0; i < genericAlert_labels.Count; i++)
            {
                Scribe_Values.Look(ref genericAlert_values[i], genericAlert_labels[i]);
            }
            for (int i = 0; i < genericLetter_labels.Count; i++)
            {
                Scribe_Values.Look(ref genericLetter_values[i], genericLetter_labels[i]);
            }

            Scribe_Values.Look(ref taintedMessagePatch, "taintedMessagePatch");
            Scribe_Values.Look(ref idleColonistsPatch, "idleColonistsPatch");
            Scribe_Values.Look(ref drawAutoSelectCheckboxPatch, "drawAutoSelectCheckboxPatch");
            base.ExposeData();
        }

        public List<string> ActiveGenericMessagePatches()
        {
            List<string> activePatches = new List<string>();

            for (int i = 0; i < genericMessage_labels.Count; i++)
            {
                if (genericMessage_values[i]) activePatches.Add(genericMessage_labels[i]);
            }

            return activePatches;
        }

        public List<string> ActiveGenericAlertPatches()
        {
            List<string> activePatches = new List<string>();

            for (int i = 0; i < genericAlert_labels.Count; i++)
            {
                if (genericAlert_values[i]) activePatches.Add(genericAlert_labels[i]);
            }

            return activePatches;
        }

        public List<string> ActiveGenericLetterPatches()
        {
            List<string> activePatches = new List<string>();

            for (int i = 0; i < genericLetter_labels.Count; i++)
            {
                if (genericLetter_values[i]) activePatches.Add(genericLetter_labels[i]);
            }

            return activePatches;
        }

        public bool GetGenericMessagePatchValue(string label)
        {
            for (int i = 0; i < genericMessage_labels.Count; i++)
            {
                if (genericMessage_labels[i] == label) return genericMessage_values[i];
            }

            throw new ArgumentException("Argument " + label + " not found in the list.");
        }

        public bool GetGenericAlertPatchValue(string label)
        {
            for (int i = 0; i < genericAlert_labels.Count; i++)
            {
                if (genericAlert_labels[i] == label) return genericAlert_values[i];
            }

            throw new ArgumentException("Argument " + label + " not found in the list.");
        }

        public bool GetGenericLetterPatchValue(string label)
        {
            for (int i = 0; i < genericLetter_labels.Count; i++)
            {
                if (genericLetter_labels[i] == label) return genericLetter_values[i];
            }

            throw new ArgumentException("Argument " + label + " not found in the list.");
        }
    }

    public class BUMMod : Mod
    {
        private enum Tab
        {
            Messages,
            Alerts,
            Letters,
            Misc
        }
        readonly BUMSettings settings;
        private static List<TabRecord> tabsList = new List<TabRecord>();
        private Tab tab = Tab.Messages;
        private Vector2 scrollPosition;
        private static string searchText = "";

        private const int LINE_MAX = 100;

        public BUMMod(ModContentPack content) : base(content)
        {
            settings = GetSettings<BUMSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            // Create tab menu area
            Rect tabRect = inRect;
            tabRect.yMin += 30f;
            
            tabsList.Clear();
            tabsList.Add(new TabRecord("Messages", (() => tab = Tab.Messages), tab == Tab.Messages));
            tabsList.Add(new TabRecord("Alerts", (() => tab = Tab.Alerts), tab == Tab.Alerts));
            tabsList.Add(new TabRecord("Letters", (() => tab = Tab.Letters), tab == Tab.Letters));
            tabsList.Add(new TabRecord("Misc", (() => tab = Tab.Misc), tab == Tab.Misc));
            
            Widgets.DrawMenuSection(tabRect);
            TabDrawer.DrawTabs(tabRect, tabsList);
            tabsList.Clear();
            
            // Create Custom and Generic menu areas

            Rect contentRect = tabRect;
            contentRect = contentRect.ContractedBy(20f);

            Rect customRect = contentRect;
            Rect genericRect = contentRect;
            genericRect.yMin += 85f;
            Rect genericTitleRect = genericRect;
            genericTitleRect.width -= 200f;
            Rect genericBtnRect = genericRect;
            genericBtnRect.width = 95f;
            genericBtnRect.height = 25f;
            genericBtnRect.x = genericTitleRect.x + genericTitleRect.width + 10f;
            genericBtnRect.y += 29f;
            Rect genericViewRect = genericRect;
            genericViewRect.yMin += 60f;

            Listing_Standard customList = new Listing_Standard();
            customList.Begin(customRect);
            Text.Font = GameFont.Medium;
            
            switch (tab)
            {
                case Tab.Messages:
                    customList.Label("Custom Message Blockers");
                    Text.Font = GameFont.Small;
                    customList.CheckboxLabeled("MessageDeterioratedAway - But only tainted apparel", ref settings.taintedMessagePatch);
                    break;
                case Tab.Alerts:
                    customList.Label("Custom Alert Blockers");
                    Text.Font = GameFont.Small;
                    customList.CheckboxLabeled("ColonistsIdle - But only for your own colonists, not guests", ref settings.idleColonistsPatch);
                    break;
                case Tab.Letters:
                    customList.Label("Custom Letter Blockers");
                    Text.Font = GameFont.Small;
                    customList.Label("No custom letter blockers currently; requests open on the workshop.");
                    break;
                case Tab.Misc:
                    customList.Label("Miscellaneous Blockers");
                    Text.Font = GameFont.Small;
                    customList.CheckboxLabeled("Remove and disable the automatically add food to caravan checkbox", ref settings.drawAutoSelectCheckboxPatch);
                    break;
            }
            customList.Gap();
            customList.GapLine();
            customList.End();

            if ((tab == Tab.Messages) || (tab == Tab.Alerts) || (tab == Tab.Letters))
            {
                Listing_Standard genericTitle = new Listing_Standard();
                genericTitle.Begin(genericTitleRect);
                Text.Font = GameFont.Medium;
                switch (tab)
                {
                    case Tab.Messages:
                        genericTitle.Label("Generic Message Blockers");
                        break;
                    case Tab.Alerts:
                        genericTitle.Label("Generic Alert Blockers");
                        break;
                    case Tab.Letters:
                        genericTitle.Label("Generic Letter Blockers");
                        break;
                }
                Text.Font = GameFont.Small;
                searchText = genericTitle.TextEntry(searchText);
                genericTitle.End();

                if (Widgets.ButtonText(genericBtnRect, "Select All")) ChangeTabPatches(true);
                genericBtnRect.x += 105f;
                if (Widgets.ButtonText(genericBtnRect, "Deselect All")) ChangeTabPatches(false);

                Rect scrollRect = genericViewRect;
                switch (tab)
                {
                    case Tab.Messages:
                        scrollRect.height = 26.1f * BUMSettings.genericMessage_labels.Count;
                        break;
                    case Tab.Alerts:
                        scrollRect.height = 26.1f * BUMSettings.genericAlert_labels.Count;
                        break;
                    case Tab.Letters:
                        scrollRect.height = 26.1f * BUMSettings.genericLetter_labels.Count;
                        break;
                }
                scrollRect.width = genericViewRect.width - 20f;
                Widgets.BeginScrollView(genericViewRect, ref scrollPosition, scrollRect);
                Rect listRect = scrollRect;
                Listing_Standard listingStandard = new Listing_Standard();
                listingStandard.verticalSpacing = 4f;
                listingStandard.Begin(listRect);


                bool searchOn = (searchText.Length > 0);
                switch (tab)
                {
                    case Tab.Messages:
                        for (int i = 0; i < BUMSettings.genericMessage_labels.Count; i++)
                        {
                            string label = BUMSettings.genericMessage_labels[i];
                            string message = label + " - " + label.Translate();

                            if (searchOn && !message.ToLower().Contains(searchText.ToLower())) continue;
                            if (message.Length > LINE_MAX) message = (message.Substring(0, LINE_MAX) + "...");

                            listingStandard.CheckboxLabeled(message, ref settings.genericMessage_values[i]);
                        }
                        break;
                    case Tab.Alerts:
                        for (int i = 0; i < BUMSettings.genericAlert_labels.Count; i++)
                        {
                            string label = BUMSettings.genericAlert_labels[i];
                            string message = label + " - " + label.Translate();

                            if (searchOn && !message.ToLower().Contains(searchText.ToLower())) continue;
                            if (message.Length > LINE_MAX) message = (message.Substring(0, LINE_MAX) + "...");

                            listingStandard.CheckboxLabeled(message, ref settings.genericAlert_values[i]);
                        }
                        break;
                    case Tab.Letters:
                        for (int i = 0; i < BUMSettings.genericLetter_labels.Count; i++)
                        {
                            string label = BUMSettings.genericLetter_labels[i];
                            string message = label + " - " + label.Translate();

                            if (searchOn && !message.ToLower().Contains(searchText.ToLower())) continue;
                            if (message.Length > LINE_MAX) message = (message.Substring(0, LINE_MAX) + "...");

                            listingStandard.CheckboxLabeled(message, ref settings.genericLetter_values[i]);
                        }
                        break;
                }

                listingStandard.End();
                Widgets.EndScrollView();
            }
            
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "BUM: Block Unwanted Minutiae";
        }
        
        public void ChangeTabPatches(bool newState)
        {
            if (newState) SoundDefOf.Checkbox_TurnedOn.PlayOneShotOnCamera();
            else SoundDefOf.Checkbox_TurnedOff.PlayOneShotOnCamera();

            switch (tab)
            {
                case Tab.Messages:
                    for (int i = 0; i < settings.genericMessage_values.Length; i++)
                        settings.genericMessage_values[i] = newState;
                    break;
                case Tab.Alerts:
                    for (int i = 0; i < settings.genericAlert_values.Length; i++)
                        settings.genericAlert_values[i] = newState;
                    break;
                case Tab.Letters:
                    for (int i = 0; i < settings.genericLetter_values.Length; i++)
                        settings.genericLetter_values[i] = newState;
                    break;
            }
        }
    }
}