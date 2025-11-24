using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace BeautyOpinionMod
{
    public class ThoughtWorker_Pretty : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
        {
            if (!other.RaceProps.Humanlike || !RelationsUtility.PawnsKnowEachOther(pawn, other))
            {
                return false;
            }
            if (RelationsUtility.IsDisfigured(other, pawn))
            {
                return false;
            }
            if (PawnUtility.IsBiologicallyOrArtificiallyBlind(pawn))
            {
                return false;
            }
            float statValue = other.GetStatValue(StatDefOf.PawnBeauty);
            if (statValue >= 10f)
            {
                return ThoughtState.ActiveAtStage(9);
            }
            if (statValue >= 9f)
            {
                return ThoughtState.ActiveAtStage(8);
            }
            if (statValue >= 8f)
            {
                return ThoughtState.ActiveAtStage(7);
            }
            if (statValue >= 7f)
            {
                return ThoughtState.ActiveAtStage(6);
            }
            if (statValue >= 6f)
            {
                return ThoughtState.ActiveAtStage(5);
            }
            if (statValue >= 5f)
            {
                return ThoughtState.ActiveAtStage(4);
            }
            if (statValue >= 4f)
            {
                return ThoughtState.ActiveAtStage(3);
            }
            if (statValue >= 3f)
            {
                return ThoughtState.ActiveAtStage(2);
            }
            if (statValue >= 2f)
            {
                return ThoughtState.ActiveAtStage(1);
            }
            if (statValue >= 1f)
            {
                return ThoughtState.ActiveAtStage(0);
            }
            return false;
        }
    }
}
