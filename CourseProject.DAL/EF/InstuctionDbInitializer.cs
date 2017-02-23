using CourseProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CourseProject.DAL.EF
{
    public class InstuctionDbInitializer : DropCreateDatabaseIfModelChanges<InstructionContext>
    {
        protected override void Seed(InstructionContext context)
        {
            Instruction s1 = new Instruction
            {
                Id = 1,
                UserId = "f13e123e-5534-4f0d-ad91-bb5d5418c11a",
                InstructionName = "Приготовление взрывной бомбы",
                Category = "Химия",
                LinkToVideo = "...",
                NumberOfLikes = 5,
                DateOfCreation = DateTime.Now
            };
            Instruction s2 = new Instruction
            {
                Id = 2,
                UserId = "f13e123e-5534-4f0d-ad91-bb5d5418c11a",
                InstructionName = "Инструкция по взрыву банкомата",
                Category = "Преступление",
                LinkToVideo = "...",
                NumberOfLikes = 99,
                DateOfCreation = DateTime.Now
            };
            Instruction s3 = new Instruction
            {
                Id = 3,
                UserId = "f13e123e-5534-4f0d-ad91-bb5d5418c11a",
                InstructionName = "Создание кошелька webmoney",
                Category = "Веб-инструкция",
                LinkToVideo = "...",
                NumberOfLikes = 2,
                DateOfCreation = DateTime.Now
            };

            Instruction s4 = new Instruction
            {
                Id = 4,
                UserId = "f13e123e-5534-4f0d-ad91-bb5d5418c11a",
                InstructionName = "Приготовление борща",
                Category = "Кулинария",
                LinkToVideo = "...",
                NumberOfLikes = 22,
                DateOfCreation = DateTime.Now
            };

            context.Instructions.Add(s1);
            context.Instructions.Add(s2);
            context.Instructions.Add(s3);
            context.Instructions.Add(s4);

            Step step1 = new Step
            {
                Id = 1,
                StepName = "Купить",
                NumberOfStep = 1,
                PathToImage = "...",
                Description = "Делаем то",
                InstructionId = 1,
            };
            Step step2 = new Step
            {
                Id = 2,
                StepName = "Приготовить",
                NumberOfStep = 2,
                PathToImage = "...",
                Description = "Делаем сё",
                InstructionId = 1,

            };
            Step step3 = new Step
            {
                Id = 3,
                StepName = "Поджечь",
                NumberOfStep = 3,
                PathToImage = "...",
                Description = "Делаем то-то",
                InstructionId = 1,
            };
            Step step12 = new Step
            {
                Id = 12,
                StepName = "Пукнуть",
                NumberOfStep = 12,
                PathToImage = "...",
                Description = "Делаем ПФФФФФ",
                InstructionId = 1,
            };
            Step step13 = new Step
            {
                Id = 13,
                StepName = "Взлететь",
                NumberOfStep = 13,
                PathToImage = "...",
                Description = "Делаем крыльями взмахи",
                InstructionId = 1,
            };
            Step step4 = new Step
            {
                Id = 1,
                StepName = "Нати",
                NumberOfStep = 1,
                PathToImage = "...",
                Description = "Делаем бла-бла",
                InstructionId = 2,
            };
            Step step5 = new Step
            {
                Id = 2,
                StepName = "Зарегестрироваться",
                NumberOfStep = 2,
                PathToImage = "...",
                Description = "Делаем сё",
                InstructionId = 3,

            };
            Step step6 = new Step
            {
                Id = 3,
                StepName = "Сьесть",
                NumberOfStep = 3,
                PathToImage = "...",
                Description = "Делаем то-то",
                InstructionId = 4,
            };

            context.Steps.Add(step1);
            context.Steps.Add(step2);
            context.Steps.Add(step3);
            context.Steps.Add(step4);
            context.Steps.Add(step5);
            context.Steps.Add(step6);
            context.Steps.Add(step12);
            context.Steps.Add(step13);

            Tag c1 = new Tag
            {
                Id = 1,
                TagName = "Взрыв",
                Instructions = new List<Instruction>() { s1, s2 }
            };
            Tag c2 = new Tag
            {
                Id = 2,
                TagName = "Еда",
                Instructions = new List<Instruction>() { s4 }
            };
            Tag c3 = new Tag
            {
                Id = 3,
                TagName = "Веб",
                Instructions = new List<Instruction>() { s3 }
            };

            context.Tags.Add(c1);
            context.Tags.Add(c2);
            context.Tags.Add(c3);

            Comment comment1 = new Comment
            {
                Id = 1,
                UserId = "MihA_aa1@mail.ru",
                InstructionId = 1,
                Contetnt = "Збс взорвал банкомат, Спасибо"
            };
            Comment comment2 = new Comment
            {
                Id = 1,
                UserId = "LOL@mail.ru",
                InstructionId = 1,
                Contetnt = "Рад стараться!"
            };
            context.Comments.Add(comment1);
            context.Comments.Add(comment2);
            base.Seed(context);
        }
    }
}