using ELearn.Core.Interfaces;
using ELearn.DataLayer.Context;
using ELearn.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Services
{
    public class CourseGroupServices : ICourseGroup

    {
        private readonly ELearnContext _context;
        public CourseGroupServices(ELearnContext context)
        {
            _context = context;
        }  
        public async Task<bool> CreateCourseGroup(CourseGroup CourseGroup)
        {
            try
            {
                await _context.CourseGroups.AddAsync(CourseGroup);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> DeleteCourseGroup(int id)
        {
            var courseGroup=await GetCourseGroupById(id);
            if(courseGroup==null)
            {
                throw new Exception("This Course Group Not Found !");
            }
            try
            {
                courseGroup.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;             
            }
        }

        public async Task<CourseGroup> GetCourseGroupById(int id)
        {
            var CourseGroup = await _context.CourseGroups.FindAsync(id);
            if( CourseGroup==null)
            {
                throw new Exception("This Course Group Not Found...");
            }
            return  CourseGroup;
        }

        public IEnumerable<CourseGroup> GetCourseGroups()
        {
            return _context.CourseGroups;
        }

        public async Task<bool> UpdateCourseGroup(CourseGroup courseGroup)
        {
           try
           {
                _context.CourseGroups.Update(courseGroup);
                await _context.SaveChangesAsync();
                return true;
           }
            catch(Exception ex)
           {
                Console.WriteLine(ex);
                return false;

           }
        }
    }
}
